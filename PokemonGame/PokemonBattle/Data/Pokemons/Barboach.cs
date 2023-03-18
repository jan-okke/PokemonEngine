using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Barboach : Pokemon
	{
		public override string Name => "Barboach";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(50, 48, 43, 46, 41, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Watergun() },
			[6] = new List<Move>() { new Rest(), new Snore() },
			[12] = new List<Move>() { new Waterpulse() },
			[18] = new List<Move>() { new Amnesia() },
			[24] = new List<Move>() { new Aquatail() },
			[31] = new List<Move>() { new Muddywater() },
			[36] = new List<Move>() { new Earthquake() },
			[42] = new List<Move>() { new Futuresight() },
			[48] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bounce(), new Bulldoze(), new Dive(), new Doubleteam(), new Dragondance(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Futuresight(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Dragondance(), new Earthpower(), new Flail(), new Hydropump(), new Muddywater(), new Mudshot(), new Spark(), new Takedown(), new Thrash(), new Whirlpool() };
		public override int Weight => 19;
		public override int ExpYield => 58;
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