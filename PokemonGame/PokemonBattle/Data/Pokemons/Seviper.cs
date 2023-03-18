using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seviper : Pokemon
	{
		public override string Name => "Seviper";
		public override List<Ability> AvailableAbilities => new() {new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(73, 100, 60, 65, 100, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Swagger() },
			[4] = new List<Move>() { new Bite() },
			[6] = new List<Move>() { new Lick() },
			[9] = new List<Move>() { new Poisontail() },
			[11] = new List<Move>() { new Feint() },
			[14] = new List<Move>() { new Screech() },
			[16] = new List<Move>() { new Venoshock() },
			[19] = new List<Move>() { new Glare() },
			[21] = new List<Move>() { new Poisonfang() },
			[24] = new List<Move>() { new Venomdrench() },
			[26] = new List<Move>() { new Nightslash() },
			[29] = new List<Move>() { new Gastroacid() },
			[31] = new List<Move>() { new Poisonjab() },
			[34] = new List<Move>() { new Haze() },
			[36] = new List<Move>() { new Swordsdance() },
			[39] = new List<Move>() { new Crunch() },
			[41] = new List<Move>() { new Belch() },
			[44] = new List<Move>() { new Coil() },
			[46] = new List<Move>() { new Sludgebomb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Bind(), new Brutalswing(), new Bulldoze(), new Confide(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragontail(), new Earthquake(), new Endure(), new Facade(), new Flamethrower(), new Frustration(), new Gastroacid(), new Gigadrain(), new Hiddenpower(), new Infestation(), new Irontail(), new Knockoff(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snatch(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Venoshock(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Bodyslam(), new Finalgambit(), new Nightslash(), new Scaryface(), new Spitup(), new Stockpile(), new Swallow(), new Switcheroo() };
		public override int Weight => 525;
		public override int ExpYield => 160;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}