using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Muk : Pokemon
	{
		public override string Name => "Muk";
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisontouch() };
		public override Stats BaseStats => new Stats(105, 105, 75, 50, 65, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Venomdrench() },
			[1] = new List<Move>() { new Venomdrench(), new Pound(), new Poisongas(), new Harden(), new Mudslap() },
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
			[46] = new List<Move>() { new Acidarmor() },
			[52] = new List<Move>() { new Belch() },
			[57] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Brickbreak(), new Confide(), new Darkpulse(), new Dig(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Infestation(), new Painsplit(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Venoshock() };
		public override int Weight => 300;
		public override int ExpYield => 175;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}