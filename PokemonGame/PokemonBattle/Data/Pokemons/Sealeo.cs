using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sealeo : Pokemon
	{
		public override string Name => "Sealeo";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Oblivious() };
		public override Stats BaseStats => new Stats(90, 60, 70, 45, 75, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Swagger() },
			[1] = new List<Move>() { new Swagger(), new Rollout(), new Defensecurl(), new Growl(), new Watergun() },
			[12] = new List<Move>() { new Powdersnow() },
			[16] = new List<Move>() { new Rest() },
			[20] = new List<Move>() { new Snore() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Aurorabeam() },
			[35] = new List<Move>() { new Encore() },
			[40] = new List<Move>() { new Bodyslam() },
			[46] = new List<Move>() { new Surf() },
			[52] = new List<Move>() { new Blizzard() },
			[58] = new List<Move>() { new Hail() },
			[64] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Dive(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Icebeam(), new Iciclespear(), new Icywind(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 876;
		public override int ExpYield => 144;
		public override int CatchRate => 120;
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