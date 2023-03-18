using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pineco : Pokemon
	{
		public override string Name => "Pineco";
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(50, 65, 90, 15, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Protect() },
			[6] = new List<Move>() { new Selfdestruct() },
			[9] = new List<Move>() { new Bugbite() },
			[12] = new List<Move>() { new Takedown() },
			[17] = new List<Move>() { new Rapidspin() },
			[20] = new List<Move>() { new Autotomize() },
			[23] = new List<Move>() { new Rollout() },
			[28] = new List<Move>() { new Spikes() },
			[31] = new List<Move>() { new Payback() },
			[34] = new List<Move>() { new Explosion() },
			[39] = new List<Move>() { new Irondefense() },
			[42] = new List<Move>() { new Gyroball() },
			[45] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbite(), new Bugbuzz(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Drillrun(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Frustration(), new Gigadrain(), new Gravity(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Painsplit(), new Payback(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Doubleedge(), new Flail(), new Pinmissile(), new Powertrick(), new Revenge(), new Sandtomb(), new Swift(), new Toxicspikes() };
		public override int Weight => 72;
		public override int ExpYield => 58;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}