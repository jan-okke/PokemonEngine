using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spheal : Pokemon
	{
		public override string Name => "Spheal";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Oblivious() };
		public override Stats BaseStats => new Stats(70, 40, 50, 55, 50, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rollout(), new Defensecurl() },
			[4] = new List<Move>() { new Growl() },
			[8] = new List<Move>() { new Watergun() },
			[12] = new List<Move>() { new Powdersnow() },
			[16] = new List<Move>() { new Rest() },
			[20] = new List<Move>() { new Snore() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Aurorabeam() },
			[33] = new List<Move>() { new Encore() },
			[36] = new List<Move>() { new Bodyslam() },
			[40] = new List<Move>() { new Surf() },
			[44] = new List<Move>() { new Blizzard() },
			[48] = new List<Move>() { new Hail() },
			[52] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Dive(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Bellydrum(), new Curse(), new Fissure(), new Rollout(), new Spitup(), new Stockpile(), new Swallow(), new Yawn() };
		public override int Weight => 395;
		public override int ExpYield => 58;
		public override int CatchRate => 255;
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