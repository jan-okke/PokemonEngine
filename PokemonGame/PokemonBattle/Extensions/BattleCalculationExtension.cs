using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class BattleCalculationExtension
    {
        public static Answer CalculateDamage(this Battle battle, bool playerTurn, Move move)
        {
            int answerCode;

            var attackingParty = playerTurn ? battle.PlayerParty : battle.EnemyParty;
            var defendingParty = playerTurn ? battle.EnemyParty : battle.PlayerParty;

            var attackingPokemon = attackingParty.GetFirstAlivePokemon();
            var defendingPokemon = defendingParty.GetFirstAlivePokemon();

            var attackingSide = playerTurn ? battle.PlayerSide : battle.EnemySide;
            var defendingSide = playerTurn ? battle.EnemySide : battle.PlayerSide;

            if (move.IsStatus) return new Answer(AnswerCodes.Answer_Calculation_StatusMove, 0); // Status Move

            bool isCriticalHit = CriticalHitCheck(attackingPokemon, defendingPokemon, move);
            answerCode = isCriticalHit ? AnswerCodes.Answer_Calculation_CriticalHit : AnswerCodes.Answer_OK;

            var power = CalculateMovePower(battle, attackingParty, defendingSide, attackingPokemon, defendingPokemon, move);
            var attack = CalculateAttack(attackingPokemon, move);
            var defense = CalculateDefense(defendingPokemon, move);
            var targetMod = CalculateTargetMod(battle, move);
            var parentalBondMod = CalculateParentalBondMod(battle, move);
            var weatherMod = CalculateWeatherMod(battle.Weather, move);
            var glaiveRushMod = CalculateGlaiveRushMod(battle, move);
            var critMod = isCriticalHit ? CalculateCritMod(attackingPokemon) : 1;
            var randomMod = CalculateRandomMod(move);
            var stabMod = CalculateStabMod(attackingPokemon, move);
            var effMod = CalculateEffectivityMod(move, defendingPokemon.Types);

            if (effMod == 0) throw new MoveHasNoEffectException(move); //return new Answer(AnswerCodes.Answer_Calculation_NoEffect, 0);

            var burnMod = CalculateBurnMod(attackingPokemon, move);
            var otherMod = CalculateOtherMod(battle, attackingPokemon, defendingPokemon, attackingParty, defendingSide, move, isCriticalHit);
            var zMod = CalculateZMod(defendingPokemon, move);
            var terraMod = CalculateTerraMod(battle, move);

            int damage = (int)(((2 * attackingPokemon.Level / 5 + 2) * power * attack / defense / 50 + 2) * targetMod * parentalBondMod * weatherMod * glaiveRushMod * critMod * randomMod * stabMod * effMod * burnMod * otherMod * zMod * terraMod);

            var answer = new Answer(answerCode, damage);
            //answer.Attributes.Add("Knocking off Item", "true"); (e.g. for knock off) => TODO

            return answer; // TODO
        }

        private static bool CriticalHitCheck(Pokemon attacker, Pokemon defender, Move move) => false; // TODO

        private static double CalculateMovePower(Battle battle, PokemonParty attackingParty, BattlerSide defenderSide, Pokemon attacker, Pokemon defender, Move move) 
        {
            double power = move.BasePower;
            // Moves
            switch (move.Name)
            {
                case "Facade": if (attacker.HasStatusCondition(StatusConditionType.Burned, StatusConditionType.Paralyzed, StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned)) power *= 2; break;
                case "Brine": if (defender.BelowHalfHP()) power *= 2; break;
                case "Venoshock": if (defender.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned)) power *= 2; break;
                case "Retaliate": if (IsRetaliateBoosted(battle)) power *= 2; break;
                case "Fusion Flare": if (battle.GetLastMove().Name == "Fusion Bolt") power *= 2; break;
                case "Fusion Bolt": if (battle.GetLastMove().Name == "Fusion Flare") power *= 2; break;
                case "Lash Out": if (StatsLoweredSameTurn(battle, attacker)) power *= 2; break;
                case "Solar Blade" or "Solar Beam": if (!battle.Weather.Surpressed(battle) && battle.Weather.IsConditionActive(WeatherCondition.Rain, WeatherCondition.Sand, WeatherCondition.Hail)) power *= 0.5; break;
                case "Knock Off": if (defender.Item.CanGetRemoved()) power *= 1.5; break;
                case "Grav Apple": if (battle.Gravity.Active) power *= 1.5; break;
                case "Misty Explosion": if (battle.IsTerrainEffectActive(TerrainEffect.Fairy) && IsGrounded(battle, attacker)) power *= 1.5; break;
                case "Expanding Force": if (battle.IsTerrainEffectActive(TerrainEffect.Psychic) && IsGrounded(battle, attacker)) power *= 1.5; break;

                case "Gust" or "Twister": if (defender.IsFlying) power *= 2; break;
                // TODO Pursuit *= 2 if defender wants to switch
                case "Smelling Salt": if (defender.HasStatusCondition(StatusConditionType.Paralyzed)) power *= 2; break;
                case "Wake-Up Slap": if (defender.HasStatusCondition(StatusConditionType.Sleeping)) power *= 2; break;
            }
            // other Boosts
            // TODO: Electromorposis and Wind Power apply this boost too (it counts as the same one and do not stack)
            if (CheckMoveType(move, PokemonType.Electric, attacker) && attacker.HasEffect(EffectType.Charged)) power *= 2;
            if (MoveWasStolenByMeFirst(battle, move)) power *= 1.5;
            // Helping Hand can be applied multiple times by giving the Pokemon multiple Effect instances of Helping Hand
            if (attacker.HasEffect(EffectType.HelpingHand)) power *= Math.Pow(1.5, attacker.EffectCount(EffectType.HelpingHand));
            if (defenderSide.HasBuff(BattlerSideBuff.MudSport) && CheckMoveType(move, PokemonType.Electric, attacker)) power *= 0.5;
            if (defenderSide.HasBuff(BattlerSideBuff.WaterSport) && CheckMoveType(move, PokemonType.Fire, attacker)) power *= 0.5;
            // Terrain
            if (battle.IsTerrainEffectActive(TerrainEffect.Grass) && IsGrounded(battle, defender) && move.NameIsAnyOf("Earthquake", "Magnitude", "Bulldoze")) power *= 0.5;
            if (battle.IsTerrainEffectActive(TerrainEffect.Fairy) && IsGrounded(battle, defender) && CheckMoveType(move, PokemonType.Dragon, attacker)) power *= 0.5;
            
            if (battle.IsTerrainEffectActive(TerrainEffect.Grass) && IsGrounded(battle, attacker) && CheckMoveType(move, PokemonType.Grass, attacker)) power *= 1.5;
            if (battle.IsTerrainEffectActive(TerrainEffect.Electric) && IsGrounded(battle, attacker) && CheckMoveType(move, PokemonType.Electric, attacker)) power *= 1.5;
            if (battle.IsTerrainEffectActive(TerrainEffect.Psychic) && IsGrounded(battle, attacker) && CheckMoveType(move, PokemonType.Psychic, attacker)) power *= 1.5;
            
            // Attacker Ability
            if (attacker.HasAbility("Rivalry")) power *= attacker.IsSameGender(defender) ? 0.75 : attacker.IsOpposingGender(defender) ? 1.25 : 1;
            if (attacker.HasAbility("Supreme Overlord")) power *= Math.Pow(1.1, Math.Min(attackingParty.FaintedCount, 5));
            if (attacker.HasAbility("Reckless") && (move.IsRecoilMove || move.HurtsOnMiss)) power *= 1.2;

            if (attacker.HasAbility("Overgrow") && attacker.BelowThirdHP() && CheckMoveType(move, PokemonType.Grass, attacker)) power *= 1.5;
            if (attacker.HasAbility("Torrent") && attacker.BelowThirdHP() && CheckMoveType(move, PokemonType.Water, attacker)) power *= 1.5;
            if (attacker.HasAbility("Blaze") && attacker.BelowThirdHP() && CheckMoveType(move, PokemonType.Fire, attacker)) power *= 1.5;
            if (attacker.HasAbility("Swarm") && attacker.BelowThirdHP() && CheckMoveType(move, PokemonType.Bug, attacker)) power *= 1.5;
            
            // Iron Fist and Punching Glove do not stack.
            if ((attacker.HasAbility("Iron Fist") || attacker.HasItem("Punching Glove")) && move.IsPunchingMove) power *= 1.2;
            if (attacker.HasAbility("Normalize")) power *= 1.2;
            if (attacker.HasAbility("Aerilate", "Pixilate", "Refrigerate", "Galvanize") && move.HasType(PokemonType.Normal)) power *= 1.2;
            if (attacker.HasAbility("Analytic") && PokemonMovedBefore(defender, attacker, battle)) power *= 1.3;
            if (attacker.HasAbility("Sand Force") && battle.Weather.IsConditionActive(WeatherCondition.Sand) & !battle.Weather.Surpressed(battle) && move.HasType(PokemonType.Ground, PokemonType.Steel, PokemonType.Rock)) power *= 1.3;
            if (attacker.HasAbility("Sheer Force") && move.HasAdditionalEffect) power *= 1.3;
            if (attacker.HasAbility("Tough Claws") && move.IsContactMove) power *= 1.3;
            if (!battle.IsSingleBattle() && attackingParty.GetAllies(battle, attacker).Any(p => p.HasAbility("Battery")) && move.IsSpecial) power *= 1.3;
            if (!battle.IsSingleBattle() && attackingParty.GetAllies(battle, attacker).Any(p => p.HasAbility("Power Spot"))) power *= 1.3;
            if (attacker.HasAbility("Punk Rock") && move.IsSoundMove) power *= 1.3;
            if (attacker.HasAbility("Strong Jaw") && move.IsBitingMove) power *= 1.5;
            if (attacker.HasAbility("Mega Launcher") && (move.IsAuraMove || move.IsPulseMove)) power *= 1.5;
            if (attacker.HasAbility("Technician") && move.BasePowerBelow(60)) power *= 1.5;
            if (attacker.HasAbility("Toxic Boost") && move.IsPhysical && attacker.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned)) power *= 1.5;
            if (attacker.HasAbility("Flare Boost") && move.IsSpecial && attacker.HasStatusCondition(StatusConditionType.Burned)) power *= 1.5;
            if (attacker.HasAbility("Steely Spirit") && CheckMoveType(move, PokemonType.Steel, attacker)) power *= 1.5;
            if (!battle.IsSingleBattle() && attackingParty.GetAllies(battle, attacker).Any(p => p.HasAbility("Steely Spirit")) && CheckMoveType(move, PokemonType.Steel, attacker)) power *= 1.5;
            if (attacker.HasAbility("Sharpness") && move.IsSlasingMove) power *= 1.5; 
            // Defender Ability
            if (defender.HasAbility("Heatproof") && move.HasType(PokemonType.Fire) & !attacker.Ability.IgnoresOtherAbilities()) power *= 0.5;
            if (defender.HasAbility("Dry Skin") && move.HasType(PokemonType.Fire) & !attacker.Ability.IgnoresOtherAbilities()) power *= 1.25;
            if (defender.HasAbility("Thick Fat") && CheckMoveType(move, PokemonType.Fire, attacker) || CheckMoveType(move, PokemonType.Ice, attacker) & !attacker.Ability.IgnoresOtherAbilities()) power *= 0.5;
            // Dark and Faira aura
            if (battle.HasActiveFieldEffect(FieldEffects.DarkAura) & !attacker.Ability.IgnoresOtherAbilities() && CheckMoveType(move, PokemonType.Dark, attacker)) power *= battle.HasActiveFieldEffect(FieldEffects.AuraBreak) ? 0.75 : 4.0 / 3.0;
            if (battle.HasActiveFieldEffect(FieldEffects.FairyAura) & !attacker.Ability.IgnoresOtherAbilities() && CheckMoveType(move, PokemonType.Fairy, attacker)) power *= battle.HasActiveFieldEffect(FieldEffects.AuraBreak) ? 0.75 : 4.0 / 3.0;
            // Items
            if (move.IsPhysical && attacker.HasItem("Muscle Band")) power *= 1.1;
            if (move.IsSpecial && attacker.HasItem("Wise Glasses")) power *= 1.1;
            if (TypeEnhancingItemMatches(move, attacker) || IncenseMatches(move, attacker) || PlateMatches(move, attacker)) power *= 1.2;
            if (LegendaryItemMatches(move, attacker)) power *= 1.2;
            if (GemMatches(move, attacker)) power *= 1.3;
            
            if (attacker.Name == "Pikachu" && attacker.HasItem("Light Ball")) power *= 2;

            return power;
        }

        private static bool CheckMoveType(Move move, PokemonType type, Pokemon attacker) => type switch
        {
            PokemonType.Normal => move.HasType(type),
            PokemonType.Water => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Grass => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Fire => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Fighting => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Rock => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Ghost => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Dark => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Psychic => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Ground => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Electric => move.HasType(type) || (attacker.HasAbility("Galvanize") && move.HasType(PokemonType.Normal)) & !attacker.HasAbility("Normalize"),
            PokemonType.Flying => move.HasType(type) || (attacker.HasAbility("Aerilate") && move.HasType(PokemonType.Normal)) & !attacker.HasAbility("Normalize"),
            PokemonType.Ice => move.HasType(type) || (attacker.HasAbility("Refrigerate") && move.HasType(PokemonType.Normal)) & !attacker.HasAbility("Normalize"),
            PokemonType.Poison => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Fairy => move.HasType(type) || (attacker.HasAbility("Pixilate") && move.HasType(PokemonType.Normal)) & !attacker.HasAbility("Normalize"),
            PokemonType.Steel => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Dragon => move.HasType(type) & !attacker.HasAbility("Normalize"),
            PokemonType.Bug => move.HasType(type) & !attacker.HasAbility("Normalize"),
            _ => throw new NotImplementedException(),
        };

        private static int CalculateAttack(Pokemon p, Move move)
            // TODO this does not include if the stat is raised or lowered!
            => move.GetTargetDefense() switch
            {
                Stat.Defense => p.Stats.Attack,
                Stat.SpecialDefense => p.Stats.SpecialAttack,
                _ => throw new ArgumentException(null, nameof(move)),
            };

        private static int CalculateDefense(Pokemon p, Move move)
            // TODO this does not include if the stat is raised or lowered!
            => move.GetTargetDefense() switch
            {
                Stat.Defense => p.Stats.Defense,
                Stat.SpecialDefense => p.Stats.SpecialDefense,
                _ => throw new ArgumentException(null, nameof(move)),
            };
        private static double CalculateTargetMod(Battle battle, Move m) => m.GetTargetCount(battle) > 1 ? 0.75 : 1; // TODO only .5 in Battle Royale

        private static double CalculateParentalBondMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateWeatherMod(Weather weather, Move move)
            // TODO Abilities that boost in weather?
            => weather.Condition switch
            {
                WeatherCondition.None => 1,
                WeatherCondition.Rain => move.Type == PokemonType.Water ? 1.5 : move.Type == PokemonType.Fire ? 0.5 : 1,
                WeatherCondition.Sun => move.Type == PokemonType.Fire ? 1.5 : move.Type == PokemonType.Water ? 0.5 : 1,
                WeatherCondition.Hail => 1,
                WeatherCondition.Sand => 1,
                _ => throw new NotImplementedException(),
            };

        private static double CalculateGlaiveRushMod(Battle battle, Move move) => 1; // TODO

        private static double CalculateCritMod(Pokemon attacker) => 1.5; // the crit mod is in otherMod!

        private static double CalculateRandomMod(Move move) => move.IsFixedRandom() ? 1 : new Random().Next(85, 101) * 0.01;

        private static double CalculateStabMod(Pokemon attacker, Move move) => attacker.HasType(move.Type) ? attacker.GetStabModBoost() : 1;

        public static double CalculateEffectivityMod(PokemonType moveType, PokemonType defendingType) => moveType switch
        {
            PokemonType.Normal => defendingType switch
            {
                PokemonType.Ghost => 0,
                PokemonType.Steel => .5,
                PokemonType.Rock => .5,
                _ => 1
            },
            PokemonType.Water => defendingType switch
            {
                PokemonType.Rock => 2,
                PokemonType.Dragon => .5,
                PokemonType.Fire => 2,
                PokemonType.Grass => .5,
                PokemonType.Ground => 2,
                PokemonType.Water => .5,
                _ => 1
            },
            PokemonType.Grass => defendingType switch
            {
                PokemonType.Poison => .5,
                PokemonType.Bug => .5,
                PokemonType.Flying => .5,
                PokemonType.Dragon => .5,
                PokemonType.Grass => .5,
                PokemonType.Ground => 2,
                PokemonType.Rock => 2,
                PokemonType.Steel => .5,
                PokemonType.Water => 2,
                PokemonType.Fire => .5,
                _ => 1
            },
            PokemonType.Fire => defendingType switch
            {
                PokemonType.Rock => .5,
                PokemonType.Bug => 2,
                PokemonType.Steel => 2,
                PokemonType.Fire => .5,
                PokemonType.Water => .5,
                PokemonType.Grass => 2,
                PokemonType.Ice => 2,
                PokemonType.Dragon => .5,
                _ => 1
            },
            PokemonType.Fighting => defendingType switch
            {
                PokemonType.Normal => 2,
                PokemonType.Flying => .5,
                PokemonType.Poison => .5,
                PokemonType.Rock => 2,
                PokemonType.Bug => .5,
                PokemonType.Ghost => 0,
                PokemonType.Steel => 2,
                PokemonType.Psychic => .5,
                PokemonType.Ice => 2,
                PokemonType.Dark => 2,
                PokemonType.Fairy => .5,
                _ => 1
            },
            PokemonType.Rock => defendingType switch
            {
                PokemonType.Fighting => .5,
                PokemonType.Flying => 2,
                PokemonType.Ground => .5,
                PokemonType.Bug => 2,
                PokemonType.Steel => .5,
                PokemonType.Fire => 2,
                PokemonType.Ice => 2,
                _ => 1
            },
            PokemonType.Ghost => defendingType switch
            {
                PokemonType.Normal => 0,
                PokemonType.Ghost => 2,
                PokemonType.Psychic => 2,
                PokemonType.Dark => .5,
                _ => 1
            },
            PokemonType.Dark => defendingType switch
            {
                PokemonType.Fighting => .5,
                PokemonType.Ghost => 2,
                PokemonType.Psychic => 2,
                PokemonType.Dark => .5,
                PokemonType.Fairy => .5,
                _ => 1
            },
            PokemonType.Psychic => defendingType switch
            {
                PokemonType.Fighting => 2,
                PokemonType.Poison => 2,
                PokemonType.Steel => .5,
                PokemonType.Psychic => .5,
                PokemonType.Dark => 0,
                _ => 1
            },
            PokemonType.Ground => defendingType switch
            {
                PokemonType.Flying => 0,
                PokemonType.Poison => 2,
                PokemonType.Rock => 2,
                PokemonType.Bug => .5,
                PokemonType.Steel => 2,
                PokemonType.Fire => 2,
                PokemonType.Grass => .5,
                PokemonType.Electric => 2,
                _ => 1
            },
            PokemonType.Electric => defendingType switch
            {
                PokemonType.Flying => 2,
                PokemonType.Ground => 0,
                PokemonType.Water => 2,
                PokemonType.Grass => .5,
                PokemonType.Electric => .5,
                PokemonType.Dragon => .5,
                _ => 1
            },
            PokemonType.Flying => defendingType switch
            {
                PokemonType.Fighting => 2,
                PokemonType.Rock => .5,
                PokemonType.Bug => 2,
                PokemonType.Steel => .5,
                PokemonType.Grass => 2,
                PokemonType.Electric => .5,
                _ => 1
            },
            PokemonType.Ice => defendingType switch
            {
                PokemonType.Flying => 2,
                PokemonType.Ground => 2,
                PokemonType.Steel => .5,
                PokemonType.Fire => .5,
                PokemonType.Water => .5,
                PokemonType.Grass => 2,
                PokemonType.Ice => .5,
                PokemonType.Dragon => 2,
                _ => 1
            },
            PokemonType.Poison => defendingType switch
            {
                PokemonType.Poison => .5,
                PokemonType.Ground => .5,
                PokemonType.Rock => .5,
                PokemonType.Ghost => .5,
                PokemonType.Steel => 0,
                PokemonType.Grass => 2,
                PokemonType.Fairy => 2,
                _ => 1
            },
            PokemonType.Fairy => defendingType switch
            {
                PokemonType.Fighting => 2,
                PokemonType.Poison => .5,
                PokemonType.Steel => .5,
                PokemonType.Fire => .5,
                PokemonType.Dragon => 2,
                PokemonType.Dark => 2,
                _ => 1
            },
            PokemonType.Steel => defendingType switch
            {
                PokemonType.Rock => 2,
                PokemonType.Steel => .5,
                PokemonType.Fire => .5,
                PokemonType.Water => .5,
                PokemonType.Electric => .5,
                PokemonType.Ice => 2,
                PokemonType.Fairy => 2,
                _ => 1
            },
            PokemonType.Dragon => defendingType switch
            {
                PokemonType.Steel => .5,
                PokemonType.Dragon => 2,
                PokemonType.Fairy => 0,
                _ => 1
            },
            PokemonType.Bug => defendingType switch
            {
                PokemonType.Fighting => .5,
                PokemonType.Flying => .5,
                PokemonType.Poison => .5,
                PokemonType.Ghost => .5,
                PokemonType.Steel => .5,
                PokemonType.Fire => .5,
                PokemonType.Grass => 2,
                PokemonType.Psychic => 2,
                PokemonType.Dark => 2,
                PokemonType.Fairy => .5,
                _ => 1
            },
            _ => throw new NotImplementedException(),
        };

        public static double CalculateEffectivityMod(Move move, List<PokemonType> types) => types.Aggregate(1.0, (result, type) => result *= CalculateEffectivityMod(move.Type, type));

        private static double CalculateBurnMod(Pokemon attacker, Move move) => attacker.HasStatusCondition(StatusConditionType.Burned) && move.IsAffectedByBurn() ? move.GetBurnMod() : 1;

        private static double CalculateOtherMod(Battle battle, Pokemon attacker, Pokemon defender, PokemonParty attackingParty, BattlerSide defenderSide, Move move, bool isCriticalHit)
        {
            double mod = 1;
            // Moves
            switch (move.Name)
            {
                case "Behemoth Blade" or "Behemoth Bash" or "Dynamax Cannon": if (defender.IsDynamaxed) mod *= 2; break;
                case "Earthquake" or "Magnitude": if (defender.IsUnderground) mod *= 2; break;
                case "Surf" or "Whirlpool": if (defender.IsUnderwater) mod *= 2; break;
                case "Collision Course" or "Electro Drift": if (CalculateEffectivityMod(move, defender.Types) > 1) mod *= 4.0 / 3.0; break;
            }
            if (move.HasExtraDamageOnMinimize && defender.IsMinimized) mod *= 2;
            if (move.IsPhysical && defenderSide.HasBuff(BattlerSideBuff.Reflect, BattlerSideBuff.AuroraVeil)) mod *= 0.5;
            if (move.IsSpecial && defenderSide.HasBuff(BattlerSideBuff.LightScreen, BattlerSideBuff.AuroraVeil)) mod *= 0.5;
            // Defender Ability
            if (defender.HasAbility("Multiscale", "Shadow Shield") && defender.AtFullHP() & !attacker.Ability.IgnoresOtherAbilities()) mod *= 0.5;
            if (defender.HasAbility("Fluffy") & !attacker.Ability.IgnoresOtherAbilities() && move.IsContactMove & !attacker.HasAbility("Long Reach")) mod *= 0.5;
            if (defender.HasAbility("Fluffy") & !attacker.Ability.IgnoresOtherAbilities() && CheckMoveType(move, PokemonType.Fire, attacker)) mod *= 2;
            if (defender.HasAbility("Punk Rock") & !attacker.Ability.IgnoresOtherAbilities() && move.IsSoundMove) mod *= 0.5;
            if (defender.HasAbility("Ice Scales") & !attacker.Ability.IgnoresOtherAbilities() && move.IsSpecial) mod *= 0.5;
            if (defender.HasAbility("Filter", "Prism Armor", "Solid Rock") & !attacker.Ability.IgnoresOtherAbilities() && CalculateEffectivityMod(move, defender.Types) > 1) mod *= 0.75;
            // Partner Ability (hitting Partner)
            if (!battle.IsSingleBattle() && attackingParty.GetAllies(battle, attacker).Find(p => p.HasAbility("Friend Guard")) == defender & !attacker.Ability.IgnoresOtherAbilities()) mod *= 0.75;
            // Attacker Ability
            if (attacker.HasAbility("Neuroforce") && CalculateEffectivityMod(move, defender.Types) > 1) mod *= 1.25;
            if (attacker.HasAbility("Sniper") && isCriticalHit) mod *= 1.5;
            if (attacker.HasAbility("Tinted Lens") && CalculateEffectivityMod(move, defender.Types) < 1) mod *= 2;
            // Items
            if (TypeResistBerryMatches(move, defender)) mod *= 0.5;
            if (attacker.HasItem("Expert Belt") && CalculateEffectivityMod(move, defender.Types) > 1) mod *= 1.2;
            if (attacker.HasItem("Life Orb")) mod *= 1.3;
            if (attacker.HasItem("Metronome")) mod *= Math.Min(1 + 0.2 * attacker.EffectCount(EffectType.MetronomeStack), 2);
            
            return mod;
        }

        private static double CalculateZMod(Pokemon defender, Move move) => defender.IsProtected ? move.IsZMove ? 0.25 : 0 : 1;

        private static double CalculateTerraMod(Battle battle, Move move) => 1; // TODO (Terra Raid Bullshit)

        private static bool IsRetaliateBoosted(Battle battle) => false; // TODO

        private static bool StatsLoweredSameTurn(Battle battle, Pokemon pokemon) => false; // TODO

        private static bool IsGrounded(Battle battle, Pokemon pokemon) => true; // TODO

        private static bool MoveWasStolenByMeFirst(Battle battle, Move move) => false; // TODO

        private static bool PokemonMovedBefore(Pokemon pokemon, Pokemon other, Battle battle) => false; // TODO

        private static bool TypeEnhancingItemMatches(Move move, Pokemon attacker)
        {
            if (attacker.HasItem("Silk Scarf") && CheckMoveType(move, PokemonType.Normal, attacker)) return true;
            if (attacker.HasItem("Charcoal") && CheckMoveType(move, PokemonType.Fire, attacker)) return true;
            if (attacker.HasItem("Mystic Water") && CheckMoveType(move, PokemonType.Water, attacker)) return true;
            if (attacker.HasItem("Magnet") && CheckMoveType(move, PokemonType.Electric, attacker)) return true;
            if (attacker.HasItem("Black Belt") && CheckMoveType(move, PokemonType.Fighting, attacker)) return true;
            if (attacker.HasItem("Black Glasses") && CheckMoveType(move, PokemonType.Dark, attacker)) return true;
            if (attacker.HasItem("Dragon Fang") && CheckMoveType(move, PokemonType.Dragon, attacker)) return true;
            if (attacker.HasItem("Hard Stone") && CheckMoveType(move, PokemonType.Rock, attacker)) return true;
            if (attacker.HasItem("Metal Coat") && CheckMoveType(move, PokemonType.Steel, attacker)) return true;
            if (attacker.HasItem("Miracle Seed") && CheckMoveType(move, PokemonType.Grass, attacker)) return true;
            if (attacker.HasItem("Never-Melt Ice") && CheckMoveType(move, PokemonType.Ice, attacker)) return true;
            if (attacker.HasItem("Poison Barb") && CheckMoveType(move, PokemonType.Poison, attacker)) return true;
            if (attacker.HasItem("Sharp Beak") && CheckMoveType(move, PokemonType.Flying, attacker)) return true;
            if (attacker.HasItem("Silver Powder") && CheckMoveType(move, PokemonType.Bug, attacker)) return true;
            if (attacker.HasItem("Soft Sand") && CheckMoveType(move, PokemonType.Ground, attacker)) return true;
            if (attacker.HasItem("Spell Tag") && CheckMoveType(move, PokemonType.Ghost, attacker)) return true;
            if (attacker.HasItem("Twisted Spoon") && CheckMoveType(move, PokemonType.Psychic, attacker)) return true;
            return false;
        }

        private static bool IncenseMatches(Move move, Pokemon attacker)
        {
            return false; // TODO
        }

        private static bool PlateMatches(Move move, Pokemon attacker)
        {
            return false; // TODO
        }

        private static bool LegendaryItemMatches(Move move, Pokemon attacker)
        {
            return false; // TODO
        }

        private static bool GemMatches(Move move, Pokemon attacker)
        {
            return false; // TODO
        }

        private static bool TypeResistBerryMatches(Move move, Pokemon defender)
        {
            return false; // TODO
        }
    }
}
