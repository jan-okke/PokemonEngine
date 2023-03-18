using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skiddo : Pokemon
	{
		public override string Name => "Skiddo";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grasspelt() };
		public override Stats BaseStats => new Stats(66, 65, 48, 62, 57, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growth() },
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
			[38] = new List<Move>() { new Doubleedge() },
			[42] = new List<Move>() { new Hornleech() },
			[45] = new List<Move>() { new Leafblade() },
			[50] = new List<Move>() { new Milkdrink() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Doubleteam(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Irontail(), new Naturepower(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Synthesis(), new Toxic(), new Wildcharge(), new Workup(), new Worryseed(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Defensecurl(), new Grassyterrain(), new Milkdrink(), new Rollout() };
		public override int Weight => 310;
		public override int ExpYield => 70;
		public override int CatchRate => 200;
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