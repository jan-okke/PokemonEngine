using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sableye : Pokemon
	{
		public override string Name => "Sableye";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Stall() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
		public override Stats BaseStats => new Stats(50, 75, 75, 65, 65, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Leer(), new Moves.Scratch() },
			[3] = new List<Move>() { new Moves.Astonish() },
			[6] = new List<Move>() { new Moves.Confuseray() },
			[9] = new List<Move>() { new Moves.Shadowsneak() },
			[12] = new List<Move>() { new Moves.Fakeout() },
			[15] = new List<Move>() { new Moves.Disable() },
			[18] = new List<Move>() { new Moves.Detect() },
			[21] = new List<Move>() { new Moves.Nightshade() },
			[24] = new List<Move>() { new Moves.Furyswipes() },
			[27] = new List<Move>() { new Moves.Knockoff() },
			[30] = new List<Move>() { new Moves.Quash() },
			[33] = new List<Move>() { new Moves.Shadowclaw() },
			[36] = new List<Move>() { new Moves.Meanlook() },
			[39] = new List<Move>() { new Moves.Powergem() },
			[42] = new List<Move>() { new Moves.Zenheadbutt() },
			[45] = new List<Move>() { new Moves.Shadowball() },
			[48] = new List<Move>() { new Moves.Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poltergeist(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Trick(), new Moves.Waterpulse(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Feint(), new Moves.Flatter(), new Moves.Imprison(), new Moves.Meanlook(), new Moves.Metalburst(), new Moves.Moonlight(), new Moves.Recover(), new Moves.Suckerpunch(), new Moves.Trick() };
		public override int Weight => 110;
		public override int ExpYield => 133;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}