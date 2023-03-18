using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dewpider : Pokemon
	{
		public override string Name => "Dewpider";
		public override List<Ability> AvailableAbilities => new() {new Waterbubble() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(38, 40, 52, 27, 40, 72);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Infestation() },
			[4] = new List<Move>() { new Bugbite() },
			[8] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Aquaring() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Crunch() },
			[28] = new List<Move>() { new Soak() },
			[32] = new List<Move>() { new Entrainment() },
			[36] = new List<Move>() { new Lunge() },
			[40] = new List<Move>() { new Liquidation() },
			[44] = new List<Move>() { new Leechlife() },
			[48] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bugbuzz(), new Crunch(), new Endure(), new Facade(), new Gigadrain(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irondefense(), new Leechlife(), new Liquidation(), new Magicroom(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Waterfall(), new Wonderroom(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Powersplit(), new Spitup(), new Stickyweb(), new Stockpile() };
		public override int Weight => 40;
		public override int ExpYield => 54;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}