using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arbok : Pokemon
	{
		public override string Name => "Arbok";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(60, 95, 69, 65, 79, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Crunch() },
			[1] = new List<Move>() { new Crunch(), new Icefang(), new Thunderfang(), new Firefang(), new Wrap(), new Leer(), new Poisonsting(), new Bite() },
			[4] = new List<Move>() { new Poisonsting() },
			[9] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Glare() },
			[17] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Acid() },
			[27] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[32] = new List<Move>() { new Acidspray() },
			[39] = new List<Move>() { new Sludgebomb() },
			[44] = new List<Move>() { new Gastroacid() },
			[48] = new List<Move>() { new Belch() },
			[51] = new List<Move>() { new Haze() },
			[56] = new List<Move>() { new Coil() },
			[63] = new List<Move>() { new Gunkshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Bind(), new Brutalswing(), new Bulldoze(), new Confide(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragontail(), new Earthquake(), new Endure(), new Facade(), new Frustration(), new Gastroacid(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Irontail(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocktomb(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snatch(), new Snore(), new Spite(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Throatchop(), new Torment(), new Venoshock() };
		public override int Weight => 650;
		public override int ExpYield => 157;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}