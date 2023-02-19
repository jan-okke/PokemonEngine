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
                case "Heat Wave": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Hurricane": if (Chance(30)) defendingPokemon.Confuse(); break;
                case "Hyper Fang": if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Ice Beam": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Ice Burn": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Ice Fang": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Ice Punch": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Icicle Crash": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Icy Wind": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Inferno": defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Iron Head": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Iron Tail": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Lava Plume": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Leaf Tornado": if (Chance(30)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Lick": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Liquidation": if (Chance(20)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Low Sweep": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Lunge": defendingPokemon.LowerStatStage(Stat.Attack, 1); break;
                case "Luster Purge": if (Chance(50)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Metal Claw": if (Chance(10)) attackingPokemon.IncreaseStatStage(Stat.Attack, 1); break;
                case "Meteor Mash": if (Chance(20)) attackingPokemon.IncreaseStatStage(Stat.Attack, 1); break;
                case "Mirror Shot": if (Chance(30)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Mist Ball": if (Chance(50)) defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Moonblast": if (Chance(30)) defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Mud Bomb": if (Chance(30)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Mud Shot": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Mud Slap": defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Muddy Water": if (Chance(30)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Mystical Fire": defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Needle Arm": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Night Daze": if (Chance(40)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Nuzzle": defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Octazooka": if (Chance(50)) defendingPokemon.LowerStatStage(SecondaryStat.Accuracy, 1); break;
                case "Ominous Wind": if (Chance(10)) attackingPokemon.IncreaseAllStatStagesBy(1); break;
                case "Play Rough": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Attack, 1); break;
                case "Poison Fang": if (Chance(50)) defendingPokemon.SetStatus(StatusConditionType.BadlyPoisoned, -1); break;
                case "Poison Jab": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Poison Sting": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Poison Tail": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Powder Snow": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Power-Up Punch": attackingPokemon.IncreaseStatStage(Stat.Attack, 1); break;
                case "Psybeam": if (Chance(10)) defendingPokemon.Confuse(); break;
                case "Psychic": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Pyro Ball": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Razor Shell": if (Chance(50)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Relic Song": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Sleeping, new Random().Next(1, 4)); break;
                case "Rock Climb": if (Chance(20)) defendingPokemon.Confuse(); break;
                case "Rock Slide": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Rock Smash": if (Chance(50)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Rock Tomb": defendingPokemon.LowerStatStage(Stat.Speed, 1); break;
                case "Rolling Kick": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Sacred Fire": if (Chance(50)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Scald": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Scorching Sands": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Searing Shot": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                // TODO Secret Power https://bulbapedia.bulbagarden.net/wiki/Secret_Power_(move)
                case "Seed Flare": if (Chance(40)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 2); break;
                case "Shadow Ball": if (Chance(20)) defendingPokemon.LowerStatStage(Stat.SpecialDefense, 1); break;
                case "Shadow Bone": if (Chance(20)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                case "Shell Side Arm": if (Chance(20)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Signal Beam": if (Chance(10)) defendingPokemon.Confuse(); break;
                case "Silver Wind": if (Chance(10)) attackingPokemon.IncreaseAllStatStagesBy(1); break;
                case "Sizzly Slide": defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Skitter Smack": defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Sky Attack": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Sludge": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Sludge Bomb": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Sludge Wave": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Smog": if (Chance(40)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Snarl": defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Snore": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Spark": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Sparkling Aria": if (defendingPokemon.HasStatusCondition(StatusConditionType.Burned)) defendingPokemon.HealStatusCondition(); break;
                case "Spirit Break": defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Spirit Shackle": defendingPokemon.Trap(); break;
                case "Splishy Splash": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Steam Eruption": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); break;
                case "Steamroller": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Steel Wing": if (Chance(10)) attackingPokemon.IncreaseStatStage(Stat.Attack, 1); break;
                case "Stoked Sparksurfer": defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Stomp": if (Chance(30)) defendingPokemon.Flinch(); break;
                case "Strange Steam": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Struggle Bug": defendingPokemon.LowerStatStage(Stat.SpecialAttack, 1); break;
                case "Throat Chop": defendingPokemon.Mute(); break;
                case "Thunder": if (Chance(30)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Thunder Fang": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); if (Chance(10)) defendingPokemon.Flinch(); break;
                case "Thunder Punch": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Thunder Shock": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Thunderbolt": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Thunderous Kick": if (Chance(10)) defendingPokemon.LowerStatStage(Stat.Defense, 1); break;
                // Tri Attack has 7% for each when it should have 6.67 (20 / 3) % TODO
                case "Tri Attack": if (Chance(7)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); if (Chance(7)) defendingPokemon.SetStatus(StatusConditionType.Burned, -1); if (Chance(7)) defendingPokemon.SetStatus(StatusConditionType.Frozen, -1); break;
                case "Trop Kick": defendingPokemon.LowerStatStage(Stat.Attack, 1); break;
                case "Twineedle": if (Chance(20)) defendingPokemon.SetStatus(StatusConditionType.Poisoned, -1); break;
                case "Twister": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Volt Tackle": if (Chance(10)) defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Water Pulse": if (Chance(20)) defendingPokemon.Confuse(); break;
                case "Waterfall": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Zap Cannon": defendingPokemon.SetStatus(StatusConditionType.Paralyzed, -1); break;
                case "Zen Headbutt": if (Chance(20)) defendingPokemon.Flinch(); break;
                case "Zing Zap": if (Chance(30)) defendingPokemon.Flinch(); break;
            }
        }
        private static bool Chance(int outOfHundred) => new Random().Next(0, 100) <= outOfHundred;
    }
}
