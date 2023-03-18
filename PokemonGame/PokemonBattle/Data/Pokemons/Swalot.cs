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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Liquidooze(), new Abilities.Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(100, 73, 83, 73, 83, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Bodyslam() },
			[1] = new List<Move>() { new Moves.Bodyslam(), new Moves.Venomdrench(), new Moves.Gunkshot(), new Moves.Pound(), new Moves.Yawn(), new Moves.Poisongas(), new Moves.Sludge() },
			[5] = new List<Move>() { new Moves.Yawn() },
			[8] = new List<Move>() { new Moves.Poisongas() },
			[10] = new List<Move>() { new Moves.Sludge() },
			[12] = new List<Move>() { new Moves.Amnesia() },
			[17] = new List<Move>() { new Moves.Acidspray() },
			[20] = new List<Move>() { new Moves.Encore() },
			[25] = new List<Move>() { new Moves.Toxic() },
			[30] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
			[37] = new List<Move>() { new Moves.Sludgebomb() },
			[42] = new List<Move>() { new Moves.Gastroacid() },
			[49] = new List<Move>() { new Moves.Belch() },
			[54] = new List<Move>() { new Moves.Painsplit() },
			[61] = new List<Move>() { new Moves.Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Painsplit(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Venoshock(), new Moves.Waterpulse() };
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