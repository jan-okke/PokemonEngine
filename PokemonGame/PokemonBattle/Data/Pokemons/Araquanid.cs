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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterbubble() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
		public override Stats BaseStats => new Stats(68, 70, 92, 50, 132, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wideguard(), new Moves.Watergun(), new Moves.Infestation(), new Moves.Bugbite(), new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Bubblebeam() },
			[16] = new List<Move>() { new Moves.Aquaring() },
			[20] = new List<Move>() { new Moves.Headbutt() },
			[26] = new List<Move>() { new Moves.Crunch() },
			[32] = new List<Move>() { new Moves.Soak() },
			[38] = new List<Move>() { new Moves.Entrainment() },
			[44] = new List<Move>() { new Moves.Lunge() },
			[50] = new List<Move>() { new Moves.Liquidation() },
			[56] = new List<Move>() { new Moves.Leechlife() },
			[62] = new List<Move>() { new Moves.Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bugbuzz(), new Moves.Crunch(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Magicroom(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Wonderroom(), new Moves.Xscissor() };
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