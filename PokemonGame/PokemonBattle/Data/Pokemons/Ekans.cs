using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ekans : Pokemon
	{
		public override string Name => "Ekans";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(35, 60, 44, 55, 40, 54);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Leer() },
			[4] = new List<Move>() { new Poisonsting() },
			[9] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Glare() },
			[17] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Acid() },
			[25] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[28] = new List<Move>() { new Acidspray() },
			[33] = new List<Move>() { new Sludgebomb() },
			[36] = new List<Move>() { new Gastroacid() },
			[38] = new List<Move>() { new Belch() },
			[41] = new List<Move>() { new Haze() },
			[44] = new List<Move>() { new Coil() },
			[49] = new List<Move>() { new Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Bind(), new Brutalswing(), new Bulldoze(), new Confide(), new Darkpulse(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Frustration(), new Gastroacid(), new Gigadrain(), new Hiddenpower(), new Infestation(), new Irontail(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocktomb(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Torment(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Beatup(), new Disable(), new Poisonfang(), new Poisontail(), new Scaryface(), new Slam(), new Spite(), new Suckerpunch(), new Switcheroo() };
		public override int Weight => 69;
		public override int ExpYield => 58;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}