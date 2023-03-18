using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mareanie : Pokemon
	{
		public override string Name => "Mareanie";
		public override List<Ability> AvailableAbilities => new() {new Merciless(), new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(50, 53, 62, 45, 43, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Peck() },
			[5] = new List<Move>() { new Wideguard() },
			[10] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Venoshock() },
			[20] = new List<Move>() { new Recover() },
			[25] = new List<Move>() { new Pinmissile() },
			[30] = new List<Move>() { new Toxicspikes() },
			[35] = new List<Move>() { new Liquidation() },
			[40] = new List<Move>() { new Venomdrench() },
			[45] = new List<Move>() { new Poisonjab() },
			[50] = new List<Move>() { new Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Endure(), new Facade(), new Gunkshot(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Muddywater(), new Mudshot(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Haze(), new Infestation(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 80;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}