using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Whismur : Pokemon
	{
		public override string Name => "Whismur";
		public override List<Ability> AvailableAbilities => new() {new Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(64, 51, 23, 28, 51, 23);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Pound() },
			[5] = new List<Move>() { new Echoedvoice() },
			[10] = new List<Move>() { new Howl() },
			[15] = new List<Move>() { new Rest(), new Sleeptalk() },
			[21] = new List<Move>() { new Stomp() },
			[25] = new List<Move>() { new Roar() },
			[30] = new List<Move>() { new Supersonic() },
			[35] = new List<Move>() { new Uproar() },
			[40] = new List<Move>() { new Screech() },
			[45] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Megakick(), new Megapunch(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Round(), new Screech(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderpunch(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Circlethrow(), new Disarmingvoice(), new Endeavor(), new Extrasensory(), new Faketears(), new Hammerarm(), new Smokescreen(), new Snore(), new Takedown(), new Whirlwind() };
		public override int Weight => 163;
		public override int ExpYield => 48;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}