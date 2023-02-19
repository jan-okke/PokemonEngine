using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class BattleEffectCheckExtension
    {
        public static void CheckEffects(this Battle battle, bool playerTurn, Move move)
        {
            var attackingParty = playerTurn ? battle.PlayerParty : battle.EnemyParty;
            var defendingParty = playerTurn ? battle.EnemyParty : battle.PlayerParty;

            var attackingPokemon = attackingParty.GetFirstAlivePokemon();
            var defendingPokemon = defendingParty.GetFirstAlivePokemon();

            var attackingSide = playerTurn ? battle.PlayerSide : battle.EnemySide;
            var defendingSide = playerTurn ? battle.EnemySide : battle.PlayerSide;

            switch (move.Name)
            {
                // TODO: abilities that increase the chance
                case "Acid": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Acid Spray": defendingPokemon.LowerStatStage(Stat.SpecialDefense, 2); break;
                case "Air Slash": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Anchor Shot": defendingPokemon.Trap(); break;
                case "Ancient Power": if (Chance(10)) attackingPokemon.IncreaseAllStatStagesBy(1); break;
                case "Apple Acid": defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Astonish": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Aura Wheel": attackingPokemon.IncreaseStatStage(Stat.Speed, 1); break;
                case "Bite": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Blaze Kick": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Blizzard": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Blue Flare": if (Chance(20)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Body Slam": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Bolt Strike": if (Chance(20)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Bone Club": if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Bounce": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Breaking Swipe": defendingPokemon.LowerStatStage(Stat.Attack, 1); break;
                case "Bubble": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Bubble Beam": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Bug Buzz": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Bulldoze": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                // TODO Burning Jealousy https://bulbapedia.bulbagarden.net/wiki/Burning_Jealousy_(move)
                case "Buzzy Buzz": defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Charge Beam": if (Chance(70)) attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1); break;
                case "Chatter": defendingPokemon.Confuse(); break;
                case "Clangorous Soulblaze": attackingPokemon.IncreaseAllStatStagesBy(1); break;
                case "Confusion": if (Chance(10)) defendingPokemon.Confuse(); break;
                case "Constrict": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Cross Poison": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Crunch": if (Chance(20)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Crush Claw": if (Chance(50)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Dark Pulse": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Diamond Storm": if (Chance(50)) attackingPokemon.IncreaseStatStage(Stat.Defense, 2); break;
                case "Discharge": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Dizzy Punch": if (Chance(20)) defendingPokemon.Confuse(); break;
                case "Double Iron Bash": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Dragon Breath": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Dragon Rush": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Drum Beating": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Dynamic Punch": defendingPokemon.Confuse(); break;
                case "Earth Power": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Eerie Spell": battle.GetLastMove().ReducePowerPoints(3); break; // TODO this should target the opposing pokemons last move. might not work!
                case "Electroweb": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Ember": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Energy Ball": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Extrasensory": if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Fake Out": defendingPokemon.Flinch(); break;
                case "Fiery Dance": if (Chance(50)) attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1); break;
                case "Fiery Wrath": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Fire Blast": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Fire Fang": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Fire Lash": defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Fire Punch": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Flame Charge": attackingPokemon.IncreaseStatStage(Stat.Speed, 1); break;
                case "Flame Wheel": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Flamethrower": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Flare Blitz": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Flash Cannon": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                // TODO Fling https://bulbapedia.bulbagarden.net/wiki/Fling_(move)
                case "Floaty Fall": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Focus Blast": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Force Palm": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Freeze Dry": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Freeze Shock": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Freezing Glare": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Genesis Supernova": battle.SetTerrain(TerrainEffect.Psychic, attackingPokemon.HasItem("Terrain Extender") ? 8 : 5); break;
                case "Glaciate": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Grav Apple": defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Headbutt": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Heart Stamp": if (Chance(30)) defendingPokemon.Flinch(); break;
            }
        }
        private static bool Chance(int outOfHundred) => new Random().Next(0, 100) >= outOfHundred;
    }
}
