using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gulpin : Pokemon
	{
		public override string Name => "Gulpin";
		public override List<Ability> AvailableAbilities => new() {new Liquidooze(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(70, 43, 53, 43, 53, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound() },
			[5] = new List<Move>() { new Yawn() },
			[8] = new List<Move>() { new Poisongas() },
			[10] = new List<Move>() { new Sludge() },
			[12] = new List<Move>() { new Amnesia() },
			[17] = new List<Move>() { new Acidspray() },
			[20] = new List<Move>() { new Encore() },
			[25] = new List<Move>() { new Toxic() },
			[28] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[33] = new List<Move>() { new Sludgebomb() },
			[36] = new List<Move>() { new Gastroacid() },
			[41] = new List<Move>() { new Belch() },
			[44] = new List<Move>() { new Painsplit() },
			[49] = new List<Move>() { new Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Confide(), new Doubleteam(), new Dreameater(), new Endure(), new Explosion(), new Facade(), new Firepunch(), new Frustration(), new Gastroacid(), new Gunkshot(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Infestation(), new Painsplit(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snatch(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderpunch(), new Toxic(), new Venoshock(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Curse(), new Destinybond(), new Gunkshot(), new Mudslap(), new Painsplit(), new Smog(), new Venomdrench() };
		public override int Weight => 103;
		public override int ExpYield => 60;
		public override int CatchRate => 225;
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