using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grimer : Pokemon
	{
		public override string Name => "Grimer";
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisontouch() };
		public override Stats BaseStats => new Stats(80, 80, 50, 40, 50, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Poisongas() },
			[4] = new List<Move>() { new Harden() },
			[7] = new List<Move>() { new Mudslap() },
			[12] = new List<Move>() { new Disable() },
			[15] = new List<Move>() { new Sludge() },
			[18] = new List<Move>() { new Smog() },
			[21] = new List<Move>() { new Minimize() },
			[26] = new List<Move>() { new Fling() },
			[29] = new List<Move>() { new Sludgebomb() },
			[32] = new List<Move>() { new Sludgewave() },
			[37] = new List<Move>() { new Screech() },
			[40] = new List<Move>() { new Gunkshot() },
			[43] = new List<Move>() { new Acidarmor() },
			[46] = new List<Move>() { new Belch() },
			[48] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Dig(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Frustration(), new Gigadrain(), new Gunkshot(), new Hiddenpower(), new Icepunch(), new Infestation(), new Painsplit(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocktomb(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Curse(), new Haze(), new Imprison(), new Lick(), new Meanlook(), new Poweruppunch(), new Scaryface(), new Shadowpunch(), new Shadowsneak(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 300;
		public override int ExpYield => 65;
		public override int CatchRate => 190;
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