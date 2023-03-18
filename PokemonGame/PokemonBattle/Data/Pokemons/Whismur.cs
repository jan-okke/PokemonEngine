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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
		public override Stats BaseStats => new Stats(64, 51, 23, 51, 23, 28);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Astonish(), new Moves.Pound() },
			[5] = new List<Move>() { new Moves.Echoedvoice() },
			[10] = new List<Move>() { new Moves.Howl() },
			[15] = new List<Move>() { new Moves.Rest(), new Moves.Sleeptalk() },
			[21] = new List<Move>() { new Moves.Stomp() },
			[25] = new List<Move>() { new Moves.Roar() },
			[30] = new List<Move>() { new Moves.Supersonic() },
			[35] = new List<Move>() { new Moves.Uproar() },
			[40] = new List<Move>() { new Moves.Screech() },
			[45] = new List<Move>() { new Moves.Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Circlethrow(), new Moves.Disarmingvoice(), new Moves.Endeavor(), new Moves.Extrasensory(), new Moves.Faketears(), new Moves.Hammerarm(), new Moves.Smokescreen(), new Moves.Snore(), new Moves.Takedown(), new Moves.Whirlwind() };
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