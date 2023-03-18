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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(50, 65, 90, 35, 35, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Protect() },
			[6] = new List<Move>() { new Moves.Selfdestruct() },
			[9] = new List<Move>() { new Moves.Bugbite() },
			[12] = new List<Move>() { new Moves.Takedown() },
			[17] = new List<Move>() { new Moves.Rapidspin() },
			[20] = new List<Move>() { new Moves.Autotomize() },
			[23] = new List<Move>() { new Moves.Rollout() },
			[28] = new List<Move>() { new Moves.Spikes() },
			[31] = new List<Move>() { new Moves.Payback() },
			[34] = new List<Move>() { new Moves.Explosion() },
			[39] = new List<Move>() { new Moves.Irondefense() },
			[42] = new List<Move>() { new Moves.Gyroball() },
			[45] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gravity(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Doubleedge(), new Moves.Flail(), new Moves.Pinmissile(), new Moves.Powertrick(), new Moves.Revenge(), new Moves.Sandtomb(), new Moves.Swift(), new Moves.Toxicspikes() };
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