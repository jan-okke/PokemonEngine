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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Merciless(), new Abilities.Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
		public override Stats BaseStats => new Stats(50, 53, 62, 43, 52, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Peck() },
			[5] = new List<Move>() { new Moves.Wideguard() },
			[10] = new List<Move>() { new Moves.Bite() },
			[15] = new List<Move>() { new Moves.Venoshock() },
			[20] = new List<Move>() { new Moves.Recover() },
			[25] = new List<Move>() { new Moves.Pinmissile() },
			[30] = new List<Move>() { new Moves.Toxicspikes() },
			[35] = new List<Move>() { new Moves.Liquidation() },
			[40] = new List<Move>() { new Moves.Venomdrench() },
			[45] = new List<Move>() { new Moves.Poisonjab() },
			[50] = new List<Move>() { new Moves.Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Endure(), new Moves.Facade(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Haze(), new Moves.Infestation(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
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