using System;
using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Interfaces;
using PokemonGame.Entities;
using System.Collections.Generic;
using System.Linq;
using PokemonGame.PokemonBattle.AI;
using PokemonGame.PokemonBattle.Constants;
using PokemonGame.PokemonBattle.Exceptions;
using PokemonGame.PokemonBattle.Handles;
using PokemonGame.PokemonBattle.Validation;

namespace PokemonGame.PokemonBattle.Entities;

public class Battle : IBattle
{
    private IPokemonParty PlayerParty { get; }
    private IPokemonParty EnemyParty { get; }
    private BattlerSide PlayerSide { get; }
    private BattlerSide EnemySide { get; }
    private Weather Weather { get; set; }
    private Terrain Terrain { get; set; }
    private Gravity Gravity { get; set; }
    private List<FieldEffect> FieldEffects { get; }
    public List<BattleFlag> BattleFlags { get; }

    public Trainer OpposingTrainer { get; internal set; }
    public BattleLog Log { get; }
    private readonly BattleType _battleType;

    private int Turn { get; set; }
    private bool IsOngoing => PlayerParty.IsAlive() && EnemyParty.IsAlive();

    private Pokemon ActivePlayerBattler => PlayerParty.GetFirstAlivePokemon();
    private Pokemon ActiveOpponentBattler => EnemyParty.GetFirstAlivePokemon();

    public Battle(IPokemonParty playerParty, IPokemonParty enemyParty, Weather weather = null, Terrain terrain = null,
        BattleType type = BattleType.SingleBattle)
    {
        PlayerParty = playerParty;
        EnemyParty = enemyParty;
        if (weather != null)
        {
            SetWeather(weather.Condition, weather.Turns);
        }
        else
        {
            Weather = new Weather(WeatherCondition.None, -1);
        }

        if (terrain != null)
        {
            SetTerrain(terrain.Effect, terrain.Turns);
        }
        else
        {
            Terrain = new Terrain(TerrainEffect.None, -1);
        }

        PlayerSide = new BattlerSide();
        EnemySide = new BattlerSide();
        FieldEffects = new List<FieldEffect>();
        BattleFlags = new List<BattleFlag>();
        Log = new BattleLog();
        Gravity = null;
        Turn = 0;
        _battleType = type;
    }

    private void SetTerrain(TerrainEffect terrainEffect, int terrainTurns)
    {
        Terrain = new Terrain(terrainEffect, terrainTurns);
    }

    private void SetWeather(WeatherCondition weatherCondition, int weatherTurns)
    {
        Weather = new Weather(weatherCondition, weatherTurns);
    }

    public void UseMove(Move move)
    {
        var aiMove = BattleAi.GetBestAiMove(ActiveOpponentBattler);
        var user = ActivePlayerBattler;
        var target = ActiveOpponentBattler;
        if (user.IsFaster(target))
        {
            // Player is faster
            HandleMoveTurn(user, target, move, true);
            if (target.IsAlive)
            {
                HandleMoveTurn(target, user, aiMove, false);
            }
        }
        else
        {
            // AI is faster
            HandleMoveTurn(target, user, aiMove, false);
            if (user.IsAlive)
            {
                HandleMoveTurn(user, target, move, true);
            }
        }

        EndTurn();
    }

    private void HandleMoveTurn(Pokemon user, Pokemon target, Move move, bool playerTurn)
    {
        /*
        if (!move.CanUse(playerTurn ? PlayerParty.GetFirstAlivePokemon() : EnemyParty.GetFirstAlivePokemon()) ||
            move.Fails(this, playerTurn))
        {
            return;
        }
        */

        var damage = CalculateDamage(user, target, playerTurn, move);
        CheckEffects(playerTurn, move);
        target.TakeDamage(damage);
        move.ReducePowerPoints(target.HasAbility("Pressure") ? 2 : 1);
    }

    private void CheckEffects(bool playerTurn, Move move)
    {
        var attackingParty = playerTurn ? PlayerParty : EnemyParty;
        var defendingParty = playerTurn ? EnemyParty : PlayerParty;

        var attackingPokemon = attackingParty.GetFirstAlivePokemon();
        var defendingPokemon = defendingParty.GetFirstAlivePokemon();

        var attackingSide = playerTurn ? PlayerSide : EnemySide;
        var defendingSide = playerTurn ? EnemySide : PlayerSide;

        switch (move.Name)
        {
            #region Damaging Moves with secondary effect

            // TODO: abilities that increase the chance
            case "Acid":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Acid Spray":
                defendingPokemon.LowerStatStage(Stat.SpecialDefense, 2);
                break;
            case "Air Slash":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Anchor Shot":
                defendingPokemon.Trap();
                break;
            case "Ancient Power":
                if (Chance(10))
                {
                    attackingPokemon.IncreaseAllStatStagesBy(1);
                }

                break;
            case "Apple Acid":
                defendingPokemon.LowerStatStage(Stat.Defense, 1);
                break;
            case "Astonish":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Aura Wheel":
                attackingPokemon.IncreaseStatStage(Stat.Speed, 1);
                break;
            case "Bite":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Blaze Kick":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Blizzard":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Blue Flare":
                if (Chance(20))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Body Slam":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Bolt Strike":
                if (Chance(20))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Bone Club":
                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Bounce":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Breaking Swipe":
                defendingPokemon.LowerStatStage(Stat.Attack, 1);
                break;
            case "Bubble":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Speed, 1);
                }

                break;
            case "Bubble Beam":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Speed, 1);
                }

                break;
            case "Bug Buzz":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Bulldoze":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            // TODO Burning Jealousy https://bulbapedia.bulbagarden.net/wiki/Burning_Jealousy_(move)
            case "Buzzy Buzz":
                defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                break;
            case "Charge Beam":
                if (Chance(70))
                {
                    attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1);
                }

                break;
            case "Chatter":
                defendingPokemon.Confuse();
                break;
            case "Clangorous Soulblaze":
                attackingPokemon.IncreaseAllStatStagesBy(1);
                break;
            case "Confusion":
                if (Chance(10))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Constrict":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Speed, 1);
                }

                break;
            case "Cross Poison":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Crunch":
                if (Chance(20))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Crush Claw":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Dark Pulse":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Diamond Storm":
                if (Chance(50))
                {
                    attackingPokemon.IncreaseStatStage(Stat.Defense, 2);
                }

                break;
            case "Discharge":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Dizzy Punch":
                if (Chance(20))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Double Iron Bash":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Dragon Breath":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Dragon Rush":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Drum Beating":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Dynamic Punch":
                defendingPokemon.Confuse();
                break;
            case "Earth Power":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Eerie Spell":
                GetLastMove().ReducePowerPoints(3);
                break; // TODO this should target the opposing pokemons last move. might not work!
            case "Electroweb":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Speed, 1);
                }

                break;
            case "Ember":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Energy Ball":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Extrasensory":
                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Fake Out":
                defendingPokemon.Flinch();
                break;
            case "Fiery Dance":
                if (Chance(50))
                {
                    attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1);
                }

                break;
            case "Fiery Wrath":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Fire Blast":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Fire Fang":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Fire Lash":
                defendingPokemon.LowerStatStage(Stat.Defense, 1);
                break;
            case "Fire Punch":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Flame Charge":
                attackingPokemon.IncreaseStatStage(Stat.Speed, 1);
                break;
            case "Flame Wheel":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Flamethrower":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Flare Blitz":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Flash Cannon":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            // TODO Fling https://bulbapedia.bulbagarden.net/wiki/Fling_(move)
            case "Floaty Fall":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Focus Blast":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Force Palm":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Freeze Dry":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Freeze Shock":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Freezing Glare":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Genesis Supernova":
                SetTerrain(TerrainEffect.Psychic, attackingPokemon.HasItem("Terrain Extender") ? 8 : 5);
                break;
            case "Glaciate":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Grav Apple":
                defendingPokemon.LowerStatStage(Stat.Defense, 1);
                break;
            case "Headbutt":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Heart Stamp":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Heat Wave":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Hurricane":
                if (Chance(30))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Hyper Fang":
                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Ice Beam":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Ice Burn":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Ice Fang":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Ice Punch":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Icicle Crash":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Icy Wind":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Inferno":
                defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                break;
            case "Iron Head":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Iron Tail":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Lava Plume":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Leaf Tornado":
                if (Chance(30))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Lick":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Liquidation":
                if (Chance(20))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Low Sweep":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Lunge":
                defendingPokemon.LowerStatStage(Stat.Attack, 1);
                break;
            case "Luster Purge":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Metal Claw":
                if (Chance(10))
                {
                    attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                }

                break;
            case "Meteor Mash":
                if (Chance(20))
                {
                    attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                }

                break;
            case "Mirror Shot":
                if (Chance(30))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Mist Ball":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                }

                break;
            case "Moonblast":
                if (Chance(30))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                }

                break;
            case "Mud Bomb":
                if (Chance(30))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Mud Shot":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Mud Slap":
                defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                break;
            case "Muddy Water":
                if (Chance(30))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Mystical Fire":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Needle Arm":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Night Daze":
                if (Chance(40))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Nuzzle":
                defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                break;
            case "Octazooka":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1);
                }

                break;
            case "Ominous Wind":
                if (Chance(10))
                {
                    attackingPokemon.IncreaseAllStatStagesBy(1);
                }

                break;
            case "Play Rough":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Attack, 1);
                }

                break;
            case "Poison Fang":
                if (Chance(50))
                {
                    defendingPokemon.SetStatus(StatusConditionType.BadlyPoisoned, -1);
                }

                break;
            case "Poison Jab":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Poison Sting":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Poison Tail":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Powder Snow":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Power-Up Punch":
                attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                break;
            case "Psybeam":
                if (Chance(10))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Psychic":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Pyro Ball":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Razor Shell":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Relic Song":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Sleeping, new Random().Next(1, 4));
                }

                break;
            case "Rock Climb":
                if (Chance(20))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Rock Slide":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Rock Smash":
                if (Chance(50))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Rock Tomb":
                defendingPokemon.LowerStatStage(Stat.Speed, 1);
                break;
            case "Rolling Kick":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Sacred Fire":
                if (Chance(50))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Scald":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Scorching Sands":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Searing Shot":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            // TODO Secret Power https://bulbapedia.bulbagarden.net/wiki/Secret_Power_(move)
            case "Seed Flare":
                if (Chance(40))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 2);
                }

                break;
            case "Shadow Ball":
                if (Chance(20))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1);
                }

                break;
            case "Shadow Bone":
                if (Chance(20))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            case "Shell Side Arm":
                if (Chance(20))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Signal Beam":
                if (Chance(10))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Silver Wind":
                if (Chance(10))
                {
                    attackingPokemon.IncreaseAllStatStagesBy(1);
                }

                break;
            case "Sizzly Slide":
                defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                break;
            case "Skitter Smack":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Sky Attack":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Sludge":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Sludge Bomb":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Sludge Wave":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Smog":
                if (Chance(40))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Snarl":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Snore":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Spark":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Sparkling Aria":
                if (defendingPokemon.HasStatusCondition(StatusConditionType.Burned))
                {
                    defendingPokemon.HealStatusCondition();
                }

                break;
            case "Spirit Break":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Spirit Shackle":
                defendingPokemon.Trap();
                break;
            case "Splishy Splash":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Steam Eruption":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                break;
            case "Steamroller":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Steel Wing":
                if (Chance(10))
                {
                    attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                }

                break;
            case "Stoked Sparksurfer":
                defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                break;
            case "Stomp":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Strange Steam":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Struggle Bug":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Throat Chop":
                defendingPokemon.Mute();
                break;
            case "Thunder":
                if (Chance(30))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Thunder Fang":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                if (Chance(10))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Thunder Punch":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Thunder Shock":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Thunderbolt":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Thunderous Kick":
                if (Chance(10))
                {
                    defendingPokemon.LowerStatStage(Stat.Defense, 1);
                }

                break;
            // Tri Attack has 7% for each when it should have 6.67 (20 / 3) % TODO
            case "Tri Attack":
                if (Chance(7))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                if (Chance(7))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Burned, -1);
                }

                if (Chance(7))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Frozen, -1);
                }

                break;
            case "Trop Kick":
                defendingPokemon.LowerStatStage(Stat.Attack, 1);
                break;
            case "Twineedle":
                if (Chance(20))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1);
                }

                break;
            case "Twister":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Volt Tackle":
                if (Chance(10))
                {
                    defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                }

                break;
            case "Water Pulse":
                if (Chance(20))
                {
                    defendingPokemon.Confuse();
                }

                break;
            case "Waterfall":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Zap Cannon":
                defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1);
                break;
            case "Zen Headbutt":
                if (Chance(20))
                {
                    defendingPokemon.Flinch();
                }

                break;
            case "Zing Zap":
                if (Chance(30))
                {
                    defendingPokemon.Flinch();
                }

                break;

            #endregion
            #region Pure Status Moves
            case "Acid Armor":
                attackingPokemon.IncreaseStatStage(Stat.Defense, 2);
                break;
            case "Acupressure":
                attackingPokemon.IncreaseRandomAvailableStatBy(2);
                break;
            case "After You": break; //TODO
            case "Agility":
                attackingPokemon.IncreaseStatStage(Stat.Speed, 2);
                break;
            case "Ally Switch": break; //TODO
            case "Amnesia":
                attackingPokemon.IncreaseStatStage(Stat.SpecialDefense, 2);
                break;
            case "Aqua Ring":
                attackingPokemon.GiveEffect(EffectType.AquaRing, -1);
                break;
            case "Aromatherapy":
                attackingParty.GetPokemons().ForEach(p => p.HealStatusCondition());
                break;
            case "Aromatic Mist": break; // TODO
            case "Assist": break; // TODO
            case "Attract":
                if (attackingPokemon.IsOpposingGender(defendingPokemon))
                {
                    defendingPokemon.Infatuate(attackingPokemon);
                }

                break;
            case "Aurora Veil":
                if (IsWeatherConditionActive(WeatherCondition.Hail) &
                    !attackingSide.HasBuff(BattlerSideBuff.AuroraVeil))
                {
                    attackingSide.GiveBuff(BattlerSideBuff.AuroraVeil);
                }

                break;
            case "Autotomize":
                attackingPokemon.Weight /= 2;
                attackingPokemon.IncreaseStatStage(Stat.Speed, 2);
                break;
            case "Baby-Doll Eyes":
                defendingPokemon.LowerStatStage(Stat.Attack, 1);
                break;
            case "Baneful Bunker":
                attackingPokemon.GiveEffect(EffectType.BanefulBunker, 1);
                break;
            case "Barrier":
                attackingPokemon.IncreaseStatStage(Stat.Defense, 2);
                break;
            case "Baton Pass": break; // TODO
            case "Belly Drum":
                if (attackingPokemon.BelowHalfHP())
                {
                    throw new Exception("Not enough hp left");
                }

                attackingPokemon.TakeDamage(attackingPokemon.Stats.HP / 2);
                attackingPokemon.IncreaseStatStage(Stat.Attack, 12);
                break;
            case "Bestow":
                attackingPokemon.TransferItem(attackingPokemon.Item, defendingPokemon);
                break;
            case "Block":
                defendingPokemon.Trap();
                break;
            case "Bulk Up":
                attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                attackingPokemon.IncreaseStatStage(Stat.Defense, 1);
                break;
            case "Calm Mind":
                attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1);
                attackingPokemon.IncreaseStatStage(Stat.SpecialDefense, 1);
                break;
            case "Camouflage": break; // TODO
            case "Captivate":
                if (attackingPokemon.IsOpposingGender(defendingPokemon))
                {
                    defendingPokemon.LowerStatStage(Stat.SpecialAttack, 2);
                }

                break;
            case "Celebrate": break; // no effect
            case "Charge":
                attackingPokemon.IncreaseStatStage(Stat.SpecialDefense, 1);
                attackingPokemon.GiveEffect(EffectType.Charged, 1);
                break;
            case "Charm":
                defendingPokemon.LowerStatStage(Stat.Attack, 2);
                break;
            case "Chilly Reception": break; // TOOD this sets up hail then switches user out
            case "Clangorous Soul":
                if (attackingPokemon.BelowThirdHP())
                {
                    throw new Exception("Not enough hp left");
                }

                attackingPokemon.TakeDamage(attackingPokemon.Stats.HP / 3);
                attackingPokemon.IncreaseAllStatStagesBy(1);
                break;
            case "Coaching": break; // TODO
            case "Coil":
                attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                attackingPokemon.IncreaseStatStage(Stat.Defense, 1);
                attackingPokemon.IncreaseStatStage(SecondaryStat.Accuracy, 1);
                break;
            case "Confide":
                defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1);
                break;
            case "Confuse Ray":
                defendingPokemon.Confuse();
                break;
            case "Conversion": break; // TODO
            case "Conversion 2": break; // TODO
            case "Copycat": break; // TODO
            case "Corrosive Gas":
                defendingPokemon.RemoveItem();
                break;
            case "Cosmic Power":
                attackingPokemon.IncreaseStatStage(Stat.SpecialAttack, 1);
                attackingPokemon.IncreaseStatStage(Stat.SpecialDefense, 1);
                break;
            case "Cotton Guard":
                attackingPokemon.IncreaseStatStage(Stat.Defense, 3);
                break;
            case "Cotton Spore":
                defendingPokemon.LowerStatStage(Stat.Speed, 2);
                break;
            case "Court Change":
                attackingSide.SwapBuffs(defendingSide);
                break;
            case "Crafty Shield": break; // TODO
            case "Curse":
                if (attackingPokemon.HasType(PokemonType.Ghost))
                {
                    if (attackingPokemon.BelowHalfHP())
                    {
                        throw new MoveFailsException(move);
                    }

                    defendingPokemon.Curse();
                }
                else
                {
                    attackingPokemon.LowerStatStage(Stat.Speed, 1);
                    attackingPokemon.IncreaseStatStage(Stat.Attack, 1);
                    attackingPokemon.IncreaseStatStage(Stat.Defense, 1);
                }

                break;
            case "Dark Void":
                defendingPokemon.SetStatus(StatusConditionType.Sleeping, new Random().Next(1, 4));
                break;
            #endregion
        }
    }

    private bool IsWeatherConditionActive(WeatherCondition condition)
    {
        return Weather.IsConditionActive(condition);
    }

    private static bool Chance(int outOfHundred) => new Random().Next(0, 100) <= outOfHundred;

    private void EndTurn()
    {
        if (!IsOngoing)
        {
            DebugConsole.WriteLine("Battle is over!");
            return;
        }

        Turn++;
        // TODO active battlers might need a fix (can cause to be the new pokemon before its sent out)
        foreach (var p in GetActiveBattlers())
        {
            p.OnTurnEnd();
        }
    }

    public void UseItem(Item item, Pokemon target)
    {
        if (item.IsPokeball)
        {
            throw new NotImplementedException();
            /*
            if (!TryCatchPokemon(target, item, out var p)) return false;
            if (PlayerParty.PokemonCount >= 6)
            {
                //player.PokemonBox.Add(p);
            }
            else
            {
                PlayerParty.AddPokemon(p);
            }

            return true;
            */
        }

        if (item.IsMedicine)
        {
            switch (item.Name)
            {
                case "Energy Root":
                    target.HealHp(120);
                    target.LowerHappiness(10, 10, 15);
                    break;
                case "Moomoo Milk":
                    target.HealHp(100);
                    break;
                case "Lemonade":
                    target.HealHp(80);
                    break;
                case "Fresh Water":
                    target.HealHp(50);
                    break;
                case "Full Restore":
                    target.HealHp();
                    target.HealStatusCondition();
                    break;
                case "Max Potion":
                    target.HealHp();
                    break;
                case "Hyper Potion":
                    target.HealHp(120);
                    break;
                case "Super Potion":
                    target.HealHp(60);
                    break;
                case "Potion":
                    target.HealHp(20);
                    break;
                case "Full Heal":
                    target.HealStatusCondition();
                    break;
                case "Burn Heal":
                    if (target.HasStatusCondition(StatusConditionType.Burned))
                    {
                        target.HealStatusCondition();
                    }

                    break;
                case "Antidote":
                    if (target.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned))
                    {
                        target.HealStatusCondition();
                    }

                    break;
                case "Paralyze Heal":
                    if (target.HasStatusCondition(StatusConditionType.Paralyzed))
                    {
                        target.HealStatusCondition();
                    }

                    break;
                case "Ice Heal":
                    if (target.HasStatusCondition(StatusConditionType.Frozen))
                    {
                        target.HealStatusCondition();
                    }

                    break;
                default: 
                    throw new Exception("Item was unknown medicine.");
            }
        }

        if (item.IsXItem)
        {
            switch (item.Name)
            {
                // TODO those item names are not correct i think?
                case "X Attack":
                    target.IncreaseStatStage(Stat.Attack, 2);
                    break;
                case "X Defense":
                    target.IncreaseStatStage(Stat.Defense, 2);
                    break;
                case "X SpAtk":
                    target.IncreaseStatStage(Stat.SpecialAttack, 2);
                    break;
                case "X SpDef":
                    target.IncreaseStatStage(Stat.SpecialDefense, 2);
                    break;
                case "X Speed":
                    target.IncreaseStatStage(Stat.Speed, 2);
                    break;
                case "X Accuracy":
                    target.IncreaseStatStage(SecondaryStat.Accuracy, 2);
                    break;
                default:
                    throw new Exception("Item was unknown X item."); // TODO safeguard effects and such via x items
            }
        }

        if (item.IsBerry)
        {
            throw new NotImplementedException();
        }
    }

    public void SwitchPokemon(Pokemon target)
    {
        // TODO
    }

    public List<Pokemon> GetActiveBattlers()
    {
        if (_battleType != BattleType.SingleBattle)
        {
            throw new NotImplementedException();
        }
        return new List<Pokemon> { PlayerParty.GetFirstAlivePokemon(), EnemyParty.GetFirstAlivePokemon() };
    }

    public BattleType GetBattleType()
    {
        return _battleType;
    }

    public BattleView GetCurrentState()
    {
        return new BattleView(Turn, ActivePlayerBattler, ActiveOpponentBattler);
    }

    private int CalculateDamage(Pokemon user, Pokemon target, bool playerTurn, Move move)
    {
        var attackingParty = playerTurn ? PlayerParty : EnemyParty;
        var defendingParty = playerTurn ? EnemyParty : PlayerParty;

        var attackingSide = playerTurn ? PlayerSide : EnemySide;
        var defendingSide = playerTurn ? EnemySide : PlayerSide;

        if (move.IsStatus)
        {
            return 0;
        }

        var isCriticalHit = CriticalHitCheck(user, target, move);

        var power = CalculateMovePower(attackingParty, defendingSide, user, target, move);
        var attack = CalculateAttack(user, move);
        var defense = CalculateDefense(target, move);
        var targetMod = CalculateTargetMod(move);
        var parentalBondMod = CalculateParentalBondMod(move);
        var weatherMod = CalculateWeatherMod(Weather, move);
        var glaiveRushMod = CalculateGlaiveRushMod(move);
        var critMod = isCriticalHit ? CalculateCritMod(user) : 1;
        var randomMod = CalculateRandomMod(move);
        var stabMod = CalculateStabMod(user, move);
        var effMod = CalculateEffectivityMod(move, target.Types);

        if (effMod == 0)
        {
            throw new MoveHasNoEffectException(move); //return new Answer(AnswerCodes.Answer_Calculation_NoEffect, 0);
        }

        var burnMod = CalculateBurnMod(user, move);
        var otherMod = CalculateOtherMod(user, target, attackingParty, defendingSide, move,
            isCriticalHit);
        var zMod = CalculateZMod(target, move);
        var terraMod = CalculateTerraMod(move);

        var damage = (int)(((2 * user.Level / 5 + 2) * power * attack / defense / 50 + 2) * targetMod *
                           parentalBondMod * weatherMod * glaiveRushMod * critMod * randomMod * stabMod * effMod *
                           burnMod * otherMod * zMod * terraMod);

        return damage;
    }

    private static bool CriticalHitCheck(Pokemon attacker, Pokemon defender, Move move)
    {
        return false; // TODO
        if (defender.HasAbility())
        {
            if (move.HasHighCriticalHitRate)
            {
            }
        }
    }

    private double CalculateMovePower(IPokemonParty attackingParty, BattlerSide defenderSide, Pokemon attacker,
        Pokemon defender, Move move)
    {
        double power = move.BasePower;
        #region Moves
        switch (move.Name)
        {
            case "Facade":
                if (attacker.HasStatusCondition(StatusConditionType.Burned, StatusConditionType.Paralyzed,
                        StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned))
                {
                    power *= 2;
                }

                break;
            case "Brine":
                if (defender.BelowHalfHP())
                {
                    power *= 2;
                }

                break;
            case "Venoshock":
                if (defender.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned))
                {
                    power *= 2;
                }

                break;
            case "Retaliate":
                if (IsRetaliateBoosted())
                {
                    power *= 2;
                }

                break;
            case "Fusion Flare":
                if (GetLastMove().Name == "Fusion Bolt")
                {
                    power *= 2;
                }

                break;
            case "Fusion Bolt":
                if (GetLastMove().Name == "Fusion Flare")
                {
                    power *= 2;
                }

                break;
            case "Lash Out":
                if (StatsLoweredSameTurn(attacker))
                {
                    power *= 2;
                }

                break;
            case "Solar Blade" or "Solar Beam":
                if (!IsSurpressingWeather() && Weather.IsConditionActive(WeatherCondition.Rain,
                        WeatherCondition.Sand, WeatherCondition.Hail))
                {
                    power *= 0.5;
                }

                break;
            case "Knock Off":
                if (defender.Item.CanGetRemoved())
                {
                    power *= 1.5;
                }

                break;
            case "Grav Apple":
                if (Gravity.Active)
                {
                    power *= 1.5;
                }

                break;
            case "Misty Explosion":
                if (IsTerrainEffectActive(TerrainEffect.Fairy) && attacker.IsGrounded())
                {
                    power *= 1.5;
                }

                break;
            case "Expanding Force":
                if (IsTerrainEffectActive(TerrainEffect.Psychic) && attacker.IsGrounded())
                {
                    power *= 1.5;
                }

                break;

            case "Gust" or "Twister":
                if (defender.IsFlying)
                {
                    power *= 2;
                }

                break;
            // TODO Pursuit *= 2 if defender wants to switch
            case "Smelling Salt":
                if (defender.HasStatusCondition(StatusConditionType.Paralyzed))
                {
                    power *= 2;
                }

                break;
            case "Wake-Up Slap":
                if (defender.HasStatusCondition(StatusConditionType.Sleeping))
                {
                    power *= 2;
                }

                break;
        }
        #endregion
        #region Other Boosts
        // TODO: Electromorphosis and Wind Power apply this boost too (it counts as the same one and do not stack)
        if (CheckMoveType(move, PokemonType.Electric, attacker) && attacker.HasEffect(EffectType.Charged))
        {
            power *= 2;
        }

        if (MoveWasStolenByMeFirst(move))
        {
            power *= 1.5;
        }

        // Helping Hand can be applied multiple times by giving the Pokemon multiple Effect instances of Helping Hand
        if (attacker.HasEffect(EffectType.HelpingHand))
        {
            power *= Math.Pow(1.5, attacker.EffectCount(EffectType.HelpingHand));
        }

        if (defenderSide.HasBuff(BattlerSideBuff.MudSport) &&
            CheckMoveType(move, PokemonType.Electric, attacker))
        {
            power *= 0.5;
        }

        if (defenderSide.HasBuff(BattlerSideBuff.WaterSport) &&
            CheckMoveType(move, PokemonType.Fire, attacker))
        {
            power *= 0.5;
        }
        #endregion
        #region Terrain
        if (IsTerrainEffectActive(TerrainEffect.Grass) && defender.IsGrounded() &&
            move.NameIsAnyOf("Earthquake", "Magnitude", "Bulldoze"))
        {
            power *= 0.5;
        }

        if (IsTerrainEffectActive(TerrainEffect.Fairy) && defender.IsGrounded() &&
            CheckMoveType(move, PokemonType.Dragon, attacker))
        {
            power *= 0.5;
        }

        if (IsTerrainEffectActive(TerrainEffect.Grass) && attacker.IsGrounded() &&
            CheckMoveType(move, PokemonType.Grass, attacker))
        {
            power *= 1.5;
        }

        if (IsTerrainEffectActive(TerrainEffect.Electric) && attacker.IsGrounded() &&
            CheckMoveType(move, PokemonType.Electric, attacker))
        {
            power *= 1.5;
        }

        if (IsTerrainEffectActive(TerrainEffect.Psychic) && attacker.IsGrounded() &&
            CheckMoveType(move, PokemonType.Psychic, attacker))
        {
            power *= 1.5;
        }
        #endregion
        #region Attacker Ability
        if (attacker.HasAbility("Rivalry"))
        {
            power *= attacker.IsSameGender(defender) ? 0.75 : attacker.IsOpposingGender(defender) ? 1.25 : 1;
        }

        if (attacker.HasAbility("Supreme Overlord"))
        {
            power *= Math.Pow(1.1, Math.Min(attackingParty.GetFaintedCount(), 5));
        }

        if (attacker.HasAbility("Reckless") && (move.IsRecoilMove || move.HurtsOnMiss))
        {
            power *= 1.2;
        }

        if (attacker.HasAbility("Overgrow") && attacker.BelowThirdHP() &&
            CheckMoveType(move, PokemonType.Grass, attacker))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Torrent") && attacker.BelowThirdHP() &&
            CheckMoveType(move, PokemonType.Water, attacker))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Blaze") && attacker.BelowThirdHP() &&
            CheckMoveType(move, PokemonType.Fire, attacker))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Swarm") && attacker.BelowThirdHP() &&
            CheckMoveType(move, PokemonType.Bug, attacker))
        {
            power *= 1.5;
        }

        // Iron Fist and Punching Glove do not stack.
        if ((attacker.HasAbility("Iron Fist") || attacker.HasItem("Punching Glove")) && move.IsPunchingMove)
        {
            power *= 1.2;
        }

        if (attacker.HasAbility("Normalize"))
        {
            power *= 1.2;
        }

        if (attacker.HasAbility("Aerilate", "Pixilate", "Refrigerate", "Galvanize") &&
            move.HasType(PokemonType.Normal))
        {
            power *= 1.2;
        }

        if (attacker.HasAbility("Analytic") && PokemonMovedBefore(defender, attacker))
        {
            power *= 1.3;
        }

        if (attacker.HasAbility("Sand Force") &&
            Weather.IsConditionActive(WeatherCondition.Sand) & !IsSurpressingWeather() &&
            move.HasType(PokemonType.Ground, PokemonType.Steel, PokemonType.Rock))
        {
            power *= 1.3;
        }

        if (attacker.HasAbility("Sheer Force") && move.HasAdditionalEffect)
        {
            power *= 1.3;
        }

        if (attacker.HasAbility("Tough Claws") && move.IsContactMove)
        {
            power *= 1.3;
        }

        if (_battleType != BattleType.SingleBattle &&
            attackingParty.GetAllies(this, attacker).Any(p => p.HasAbility("Battery")) &&
            move.IsSpecial)
        {
            power *= 1.3;
        }

        if (_battleType != BattleType.SingleBattle &&
            attackingParty.GetAllies(this, attacker).Any(p => p.HasAbility("Power Spot")))
        {
            power *= 1.3;
        }

        if (attacker.HasAbility("Punk Rock") && move.IsSoundMove)
        {
            power *= 1.3;
        }

        if (attacker.HasAbility("Strong Jaw") && move.IsBitingMove)
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Mega Launcher") && (move.IsAuraMove || move.IsPulseMove))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Technician") && move.BasePowerBelow(60))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Toxic Boost") && move.IsPhysical &&
            attacker.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Flare Boost") && move.IsSpecial &&
            attacker.HasStatusCondition(StatusConditionType.Burned))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Steely Spirit") && CheckMoveType(move, PokemonType.Steel, attacker))
        {
            power *= 1.5;
        }

        if (_battleType != BattleType.SingleBattle &&
            attackingParty.GetAllies(this, attacker).Any(p => p.HasAbility("Steely Spirit")) &&
            CheckMoveType(move, PokemonType.Steel, attacker))
        {
            power *= 1.5;
        }

        if (attacker.HasAbility("Sharpness") && move.IsSlasingMove)
        {
            power *= 1.5;
        }
        #endregion
        #region Defender Ability
        if (defender.HasAbility("Heatproof") &&
            move.HasType(PokemonType.Fire) & !attacker.Ability.IgnoresOtherAbilities())
        {
            power *= 0.5;
        }

        if (defender.HasAbility("Dry Skin") &&
            move.HasType(PokemonType.Fire) & !attacker.Ability.IgnoresOtherAbilities())
        {
            power *= 1.25;
        }

        if (defender.HasAbility("Thick Fat") && CheckMoveType(move, PokemonType.Fire, attacker) ||
            CheckMoveType(move, PokemonType.Ice, attacker) & !attacker.Ability.IgnoresOtherAbilities())
        {
            power *= 0.5;
        }
        #endregion
        #region Aura
        if (HasActiveFieldEffect(Enums.FieldEffects.DarkAura) & !attacker.Ability.IgnoresOtherAbilities() &&
            CheckMoveType(move, PokemonType.Dark, attacker))
        {
            power *= HasActiveFieldEffect(Enums.FieldEffects.AuraBreak) ? 0.75 : 4.0 / 3.0;
        }

        if (HasActiveFieldEffect(Enums.FieldEffects.FairyAura) & !attacker.Ability.IgnoresOtherAbilities() &&
            CheckMoveType(move, PokemonType.Fairy, attacker))
        {
            power *= HasActiveFieldEffect(Enums.FieldEffects.AuraBreak) ? 0.75 : 4.0 / 3.0;
        }
        #endregion
        #region Items
        if (move.IsPhysical && attacker.HasItem("Muscle Band"))
        {
            power *= 1.1;
        }

        if (move.IsSpecial && attacker.HasItem("Wise Glasses"))
        {
            power *= 1.1;
        }

        if (TypeEnhancingItemMatches(move, attacker) || IncenseMatches(move, attacker) ||
            PlateMatches(move, attacker))
        {
            power *= 1.2;
        }

        if (LegendaryItemMatches(move, attacker))
        {
            power *= 1.2;
        }

        if (GemMatches(move, attacker))
        {
            power *= 1.3;
        }

        if (attacker.Name == "Pikachu" && attacker.HasItem("Light Ball"))
        {
            power *= 2;
        }
        #endregion
        return power;
    }

    private bool HasActiveFieldEffect(FieldEffects effect)
    {
        return FieldEffects.Any(f => f.Effects == effect && f.IsActive);
    }

    private bool IsTerrainEffectActive(TerrainEffect effect)
    {
        return Terrain.HasEffect(effect);
    }

    private Move GetLastMove()
    {
        throw new NotImplementedException();
    }

    private bool IsSurpressingWeather()
    {
        return GetActiveBattlers().Any(p => p.HasAbility("Cloud Nine", "Air Lock"));
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
        PokemonType.Electric => move.HasType(type) ||
                                (attacker.HasAbility("Galvanize") && move.HasType(PokemonType.Normal)) &
                                !attacker.HasAbility("Normalize"),
        PokemonType.Flying => move.HasType(type) ||
                              (attacker.HasAbility("Aerilate") && move.HasType(PokemonType.Normal)) &
                              !attacker.HasAbility("Normalize"),
        PokemonType.Ice => move.HasType(type) ||
                           (attacker.HasAbility("Refrigerate") && move.HasType(PokemonType.Normal)) &
                           !attacker.HasAbility("Normalize"),
        PokemonType.Poison => move.HasType(type) & !attacker.HasAbility("Normalize"),
        PokemonType.Fairy => move.HasType(type) ||
                             (attacker.HasAbility("Pixilate") && move.HasType(PokemonType.Normal)) &
                             !attacker.HasAbility("Normalize"),
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

    private double CalculateTargetMod(Move m) => m.GetTargetCount(this) > 1 ? 0.75 : 1; // TODO only .5 in Battle Royale

    private double CalculateParentalBondMod(Move move) => 1; // TODO

    private static double CalculateWeatherMod(Weather weather, Move move) // TODO Abilities that boost in weather?
    {
        return weather.Condition switch
        {
            WeatherCondition.None => 1,
            WeatherCondition.Rain => move.Type switch
            {
                PokemonType.Water => 1.5,
                PokemonType.Fire => 0.5,
                _ => 1
            },
            WeatherCondition.Sun => move.Type switch
            {
                PokemonType.Fire => 1.5,
                PokemonType.Water => 0.5,
                _ => 1
            },
            WeatherCondition.Hail => 1,
            WeatherCondition.Sand => 1,
            _ => throw new NotImplementedException(),
        };
    }

    private double CalculateGlaiveRushMod(Move move) => 1; // TODO

    private static double CalculateCritMod(Pokemon attacker) => 1.5; // the crit mod is in otherMod!

    private static double CalculateRandomMod(Move move) => move.IsFixedRandom() ? 1 : new Random().Next(85, 101) * 0.01;

    private static double CalculateStabMod(Pokemon attacker, Move move) =>
        attacker.HasType(move.Type) ? attacker.GetStabModBoost() : 1;

    private static double CalculateEffectivityMod(PokemonType moveType, PokemonType defendingType)
    {
        return moveType switch
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
    }

    private static double CalculateEffectivityMod(Move move, List<PokemonType> types) =>
        types.Aggregate(1.0, (result, type) => result *= CalculateEffectivityMod(move.Type, type));

    private static double CalculateBurnMod(Pokemon attacker, Move move) =>
        attacker.HasStatusCondition(StatusConditionType.Burned) && move.IsAffectedByBurn() ? move.GetBurnMod() : 1;

    private double CalculateOtherMod(Pokemon attacker, Pokemon defender, IPokemonParty attackingParty,
        BattlerSide defenderSide, Move move, bool isCriticalHit)
    {
        double mod = 1;
        // Moves
        switch (move.Name)
        {
            case "Behemoth Blade" or "Behemoth Bash" or "Dynamax Cannon":
                if (defender.IsDynamaxed)
                {
                    mod *= 2;
                }

                break;
            case "Earthquake" or "Magnitude":
                if (defender.IsUnderground)
                {
                    mod *= 2;
                }

                break;
            case "Surf" or "Whirlpool":
                if (defender.IsUnderwater)
                {
                    mod *= 2;
                }

                break;
            case "Collision Course" or "Electro Drift":
                if (CalculateEffectivityMod(move, defender.Types) > 1)
                {
                    mod *= 4.0 / 3.0;
                }

                break;
        }

        if (move.HasExtraDamageOnMinimize && defender.IsMinimized)
        {
            mod *= 2;
        }

        if (move.IsPhysical && defenderSide.HasBuff(BattlerSideBuff.Reflect, BattlerSideBuff.AuroraVeil))
        {
            mod *= 0.5;
        }

        if (move.IsSpecial && defenderSide.HasBuff(BattlerSideBuff.LightScreen, BattlerSideBuff.AuroraVeil))
        {
            mod *= 0.5;
        }

        // Defender Ability
        if (defender.HasAbility("Multiscale", "Shadow Shield") &&
            defender.AtFullHP() & !attacker.Ability.IgnoresOtherAbilities())
        {
            mod *= 0.5;
        }

        if (defender.HasAbility("Fluffy") & !attacker.Ability.IgnoresOtherAbilities() &&
            move.IsContactMove & !attacker.HasAbility("Long Reach"))
        {
            mod *= 0.5;
        }

        if (defender.HasAbility("Fluffy") & !attacker.Ability.IgnoresOtherAbilities() &&
            CheckMoveType(move, PokemonType.Fire, attacker))
        {
            mod *= 2;
        }

        if (defender.HasAbility("Punk Rock") & !attacker.Ability.IgnoresOtherAbilities() &&
            move.IsSoundMove)
        {
            mod *= 0.5;
        }

        if (defender.HasAbility("Ice Scales") & !attacker.Ability.IgnoresOtherAbilities() && move.IsSpecial)
        {
            mod *= 0.5;
        }

        if (defender.HasAbility("Filter", "Prism Armor", "Solid Rock") & !attacker.Ability.IgnoresOtherAbilities() &&
            CalculateEffectivityMod(move, defender.Types) > 1)
        {
            mod *= 0.75;
        }

        // Partner Ability (hitting Partner)
        if (_battleType != BattleType.SingleBattle &&
            attackingParty.GetAllies(this, attacker).Find(p => p.HasAbility("Friend Guard")) == defender &
            !attacker.Ability.IgnoresOtherAbilities())
        {
            mod *= 0.75;
        }

        // Attacker Ability
        if (attacker.HasAbility("Neuroforce") && CalculateEffectivityMod(move, defender.Types) > 1)
        {
            mod *= 1.25;
        }

        if (attacker.HasAbility("Sniper") && isCriticalHit)
        {
            mod *= 1.5;
        }

        if (attacker.HasAbility("Tinted Lens") && CalculateEffectivityMod(move, defender.Types) < 1)
        {
            mod *= 2;
        }

        // Items
        if (TypeResistBerryMatches(move, defender))
        {
            mod *= 0.5;
        }

        if (attacker.HasItem("Expert Belt") && CalculateEffectivityMod(move, defender.Types) > 1)
        {
            mod *= 1.2;
        }

        if (attacker.HasItem("Life Orb"))
        {
            mod *= 1.3;
        }

        if (attacker.HasItem("Choice Band") && move.IsPhysical)
        {
            mod *= 1.5;
        }

        if (attacker.HasItem("Choice Specs") && move.IsSpecial)
        {
            mod *= 1.5;
        }

        if (attacker.HasItem("Metronome"))
        {
            mod *= Math.Min(1 + 0.2 * attacker.EffectCount(EffectType.MetronomeStack), 2);
        }

        return mod;
    }

    private static double CalculateZMod(Pokemon defender, Move move) =>
        defender.IsProtected ? move.IsZMove ? 0.25 : 0 : 1;

    private double CalculateTerraMod(Move move) => 1; // TODO (Terra Raid Bullshit)

    private bool IsRetaliateBoosted() => false; // TODO

    private bool StatsLoweredSameTurn(Pokemon pokemon) => false; // TODO

    private bool MoveWasStolenByMeFirst(Move move) => false; // TODO

    private bool PokemonMovedBefore(Pokemon pokemon, Pokemon other) => false; // TODO

    private static bool TypeEnhancingItemMatches(Move move, Pokemon attacker)
    {
        if (attacker.HasItem("Silk Scarf") && CheckMoveType(move, PokemonType.Normal, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Charcoal") && CheckMoveType(move, PokemonType.Fire, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Mystic Water") && CheckMoveType(move, PokemonType.Water, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Magnet") && CheckMoveType(move, PokemonType.Electric, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Black Belt") && CheckMoveType(move, PokemonType.Fighting, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Black Glasses") && CheckMoveType(move, PokemonType.Dark, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Dragon Fang") && CheckMoveType(move, PokemonType.Dragon, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Hard Stone") && CheckMoveType(move, PokemonType.Rock, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Metal Coat") && CheckMoveType(move, PokemonType.Steel, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Miracle Seed") && CheckMoveType(move, PokemonType.Grass, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Never-Melt Ice") && CheckMoveType(move, PokemonType.Ice, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Poison Barb") && CheckMoveType(move, PokemonType.Poison, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Sharp Beak") && CheckMoveType(move, PokemonType.Flying, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Silver Powder") && CheckMoveType(move, PokemonType.Bug, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Soft Sand") && CheckMoveType(move, PokemonType.Ground, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Spell Tag") && CheckMoveType(move, PokemonType.Ghost, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Twisted Spoon") && CheckMoveType(move, PokemonType.Psychic, attacker))
        {
            return true;
        }

        return false;
    }

    private static bool IncenseMatches(Move move, Pokemon attacker)
    {
        if (!attacker.HasItem())
        {
            return false; // save time if not needed to check for specific item
        }

        if (attacker.HasItem("Odd Incense") && CheckMoveType(move, PokemonType.Psychic, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Rock Incense") && CheckMoveType(move, PokemonType.Rock, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Rose Incense") && CheckMoveType(move, PokemonType.Grass, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Sea Incense", "Wave Incense") &&
            CheckMoveType(move, PokemonType.Water, attacker))
        {
            return true;
        }

        return false;
    }

    private static bool PlateMatches(Move move, Pokemon attacker)
    {
        if (!attacker.HasItem())
        {
            return false; // save time if not needed to check for specific item
        }

        if (attacker.HasItem("Blank Plate") && CheckMoveType(move, PokemonType.Normal, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Draco Plate") && CheckMoveType(move, PokemonType.Dragon, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Dread Plate") && CheckMoveType(move, PokemonType.Dark, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Earth Plate") && CheckMoveType(move, PokemonType.Ground, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Fist Plate") && CheckMoveType(move, PokemonType.Fighting, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Flame Plate") && CheckMoveType(move, PokemonType.Fire, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Icicle Plate") && CheckMoveType(move, PokemonType.Ice, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Insect Plate") && CheckMoveType(move, PokemonType.Bug, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Iron Plate") && CheckMoveType(move, PokemonType.Steel, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Meadow Plate") && CheckMoveType(move, PokemonType.Grass, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Mind Plate") && CheckMoveType(move, PokemonType.Psychic, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Pixie Plate") && CheckMoveType(move, PokemonType.Fairy, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Sky Plate") && CheckMoveType(move, PokemonType.Flying, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Splash Plate") && CheckMoveType(move, PokemonType.Water, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Spooky Plate") && CheckMoveType(move, PokemonType.Ghost, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Stone Plate") && CheckMoveType(move, PokemonType.Rock, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Toxic Plate") && CheckMoveType(move, PokemonType.Poison, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Zap Plate") && CheckMoveType(move, PokemonType.Electric, attacker))
        {
            return true;
        }

        return false;
    }

    private static bool LegendaryItemMatches(Move move, Pokemon attacker)
    {
        return false; // TODO
    }

    private static bool GemMatches(Move move, Pokemon attacker)
    {
        if (!attacker.HasItem())
        {
            return false; // save time if not needed to check for specific item
        }

        if (attacker.HasItem("Normal Gem") && CheckMoveType(move, PokemonType.Normal, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Dragon Gem") && CheckMoveType(move, PokemonType.Dragon, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Dark Gem") && CheckMoveType(move, PokemonType.Dark, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Ground Gem") && CheckMoveType(move, PokemonType.Ground, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Fighting Gem") && CheckMoveType(move, PokemonType.Fighting, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Fire Gem") && CheckMoveType(move, PokemonType.Fire, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Ice Gem") && CheckMoveType(move, PokemonType.Ice, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Bug Gem") && CheckMoveType(move, PokemonType.Bug, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Steel Gem") && CheckMoveType(move, PokemonType.Steel, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Grass Gem") && CheckMoveType(move, PokemonType.Grass, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Psychic Gem") && CheckMoveType(move, PokemonType.Psychic, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Fairy Gem") && CheckMoveType(move, PokemonType.Fairy, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Flying Gem") && CheckMoveType(move, PokemonType.Flying, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Water Gem") && CheckMoveType(move, PokemonType.Water, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Ghost Gem") && CheckMoveType(move, PokemonType.Ghost, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Rock Gem") && CheckMoveType(move, PokemonType.Rock, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Poison Gem") && CheckMoveType(move, PokemonType.Poison, attacker))
        {
            return true;
        }

        if (attacker.HasItem("Electric Gem") && CheckMoveType(move, PokemonType.Electric, attacker))
        {
            return true;
        }

        return false;
    }

    private static bool TypeResistBerryMatches(Move move, Pokemon defender)
    {
        return false; // TODO
    }
}