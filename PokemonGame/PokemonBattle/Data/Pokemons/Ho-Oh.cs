using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ho-Oh : Pokemon
	{
		public override string Name => "Ho-Oh";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(106, 130, 90, 90, 110, 154);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Whirlwind(), new Weatherball(), new Ancientpower() },
			[9] = new List<Move>() { new Lifedew() },
			[18] = new List<Move>() { new Safeguard() },
			[27] = new List<Move>() { new Calmmind() },
			[36] = new List<Move>() { new Extrasensory() },
			[45] = new List<Move>() { new Recover() },
			[54] = new List<Move>() { new Sacredfire() },
			[63] = new List<Move>() { new Sunnyday() },
			[72] = new List<Move>() { new Fireblast() },
			[81] = new List<Move>() { new Futuresight() },
			[90] = new List<Move>() { new Skyattack() },
			[99] = new List<Move>() { new Burnup() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Bravebird(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Defog(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Flash(), new Fly(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Ironhead(), new Lightscreen(), new Mysticalfire(), new Overheat(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Scorchingsands(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Weatherball(), new Willowisp(), new Zenheadbutt() };
		public override int Weight => 1990;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}