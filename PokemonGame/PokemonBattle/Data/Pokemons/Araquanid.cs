using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Araquanid : Pokemon
	{
		public override string Name => "Araquanid";
		public override List<Ability> AvailableAbilities => new() {new Waterbubble() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(68, 70, 92, 42, 50, 132);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wideguard(), new Watergun(), new Infestation(), new Bugbite(), new Bite() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Aquaring() },
			[20] = new List<Move>() { new Headbutt() },
			[26] = new List<Move>() { new Crunch() },
			[32] = new List<Move>() { new Soak() },
			[38] = new List<Move>() { new Entrainment() },
			[44] = new List<Move>() { new Lunge() },
			[50] = new List<Move>() { new Liquidation() },
			[56] = new List<Move>() { new Leechlife() },
			[62] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bugbuzz(), new Crunch(), new Dive(), new Endure(), new Facade(), new Gigadrain(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Leechlife(), new Liquidation(), new Magicroom(), new Poisonjab(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Scald(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Waterfall(), new Wonderroom(), new Xscissor() };
		public override int Weight => 820;
		public override int ExpYield => 159;
		public override int CatchRate => 100;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}