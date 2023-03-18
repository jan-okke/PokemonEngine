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
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Stall() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(50, 75, 75, 65, 65, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Scratch() },
			[3] = new List<Move>() { new Astonish() },
			[6] = new List<Move>() { new Confuseray() },
			[9] = new List<Move>() { new Shadowsneak() },
			[12] = new List<Move>() { new Fakeout() },
			[15] = new List<Move>() { new Disable() },
			[18] = new List<Move>() { new Detect() },
			[21] = new List<Move>() { new Nightshade() },
			[24] = new List<Move>() { new Furyswipes() },
			[27] = new List<Move>() { new Knockoff() },
			[30] = new List<Move>() { new Quash() },
			[33] = new List<Move>() { new Shadowclaw() },
			[36] = new List<Move>() { new Meanlook() },
			[39] = new List<Move>() { new Powergem() },
			[42] = new List<Move>() { new Zenheadbutt() },
			[45] = new List<Move>() { new Shadowball() },
			[48] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Attract(), new Bodyslam(), new Brickbreak(), new Calmmind(), new Cut(), new Darkpulse(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Foulplay(), new Gyroball(), new Helpinghand(), new Hex(), new Hiddenpower(), new Icepunch(), new Icywind(), new Imprison(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Payback(), new Poisonjab(), new Poltergeist(), new Powergem(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Trick(), new Waterpulse(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Feint(), new Flatter(), new Imprison(), new Meanlook(), new Metalburst(), new Moonlight(), new Recover(), new Suckerpunch(), new Trick() };
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