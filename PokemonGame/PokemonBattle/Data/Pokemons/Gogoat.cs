using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gogoat : Pokemon
	{
		public override string Name => "Gogoat";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grasspelt() };
		public override Stats BaseStats => new Stats(123, 100, 62, 97, 81, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Aerialace() },
			[1] = new List<Move>() { new Aerialace(), new Earthquake(), new Tackle(), new Growth(), new Vinewhip(), new Tailwhip() },
			[7] = new List<Move>() { new Vinewhip() },
			[9] = new List<Move>() { new Tailwhip() },
			[12] = new List<Move>() { new Leechseed() },
			[13] = new List<Move>() { new Razorleaf() },
			[16] = new List<Move>() { new Worryseed() },
			[20] = new List<Move>() { new Synthesis() },
			[22] = new List<Move>() { new Takedown() },
			[26] = new List<Move>() { new Bulldoze() },
			[30] = new List<Move>() { new Seedbomb() },
			[34] = new List<Move>() { new Bulkup() },
			[40] = new List<Move>() { new Doubleedge() },
			[47] = new List<Move>() { new Hornleech() },
			[55] = new List<Move>() { new Leafblade() },
			[58] = new List<Move>() { new Milkdrink() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Doubleteam(), new Earthquake(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Naturepower(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Synthesis(), new Toxic(), new Wildcharge(), new Workup(), new Worryseed(), new Zenheadbutt() };
		public override int Weight => 910;
		public override int ExpYield => 186;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}