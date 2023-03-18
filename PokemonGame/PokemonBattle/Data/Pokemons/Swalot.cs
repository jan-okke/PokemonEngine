using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swalot : Pokemon
	{
		public override string Name => "Swalot";
		public override List<Ability> AvailableAbilities => new() {new Liquidooze(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(100, 73, 83, 55, 73, 83);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bodyslam() },
			[1] = new List<Move>() { new Bodyslam(), new Venomdrench(), new Gunkshot(), new Pound(), new Yawn(), new Poisongas(), new Sludge() },
			[5] = new List<Move>() { new Yawn() },
			[8] = new List<Move>() { new Poisongas() },
			[10] = new List<Move>() { new Sludge() },
			[12] = new List<Move>() { new Amnesia() },
			[17] = new List<Move>() { new Acidspray() },
			[20] = new List<Move>() { new Encore() },
			[25] = new List<Move>() { new Toxic() },
			[30] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[37] = new List<Move>() { new Sludgebomb() },
			[42] = new List<Move>() { new Gastroacid() },
			[49] = new List<Move>() { new Belch() },
			[54] = new List<Move>() { new Painsplit() },
			[61] = new List<Move>() { new Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Bulldoze(), new Bulletseed(), new Confide(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Firepunch(), new Frustration(), new Gastroacid(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Infestation(), new Painsplit(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snatch(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderpunch(), new Toxic(), new Venoshock(), new Waterpulse() };
		public override int Weight => 800;
		public override int ExpYield => 163;
		public override int CatchRate => 75;
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