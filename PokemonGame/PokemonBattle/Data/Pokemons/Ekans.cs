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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
		public override Stats BaseStats => new Stats(35, 60, 44, 40, 54, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wrap(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Poisonsting() },
			[9] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Glare() },
			[17] = new List<Move>() { new Moves.Screech() },
			[20] = new List<Move>() { new Moves.Acid() },
			[25] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
			[28] = new List<Move>() { new Moves.Acidspray() },
			[33] = new List<Move>() { new Moves.Sludgebomb() },
			[36] = new List<Move>() { new Moves.Gastroacid() },
			[38] = new List<Move>() { new Moves.Belch() },
			[41] = new List<Move>() { new Moves.Haze() },
			[44] = new List<Move>() { new Moves.Coil() },
			[49] = new List<Move>() { new Moves.Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Irontail(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Torment(), new Moves.Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Beatup(), new Moves.Disable(), new Moves.Poisonfang(), new Moves.Poisontail(), new Moves.Scaryface(), new Moves.Slam(), new Moves.Spite(), new Moves.Suckerpunch(), new Moves.Switcheroo() };
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