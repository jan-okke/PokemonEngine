using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toxapex : Pokemon
	{
		public override string Name => "Toxapex";
		public override List<Ability> AvailableAbilities => new() {new Merciless(), new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(50, 63, 152, 35, 53, 142);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Banefulbunker() },
			[1] = new List<Move>() { new Banefulbunker(), new Poisonsting(), new Peck(), new Wideguard(), new Bite() },
			[15] = new List<Move>() { new Venoshock() },
			[20] = new List<Move>() { new Recover() },
			[25] = new List<Move>() { new Pinmissile() },
			[30] = new List<Move>() { new Toxicspikes() },
			[35] = new List<Move>() { new Liquidation() },
			[42] = new List<Move>() { new Venomdrench() },
			[49] = new List<Move>() { new Poisonjab() },
			[56] = new List<Move>() { new Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Crosspoison(), new Endure(), new Facade(), new Gunkshot(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Lightscreen(), new Liquidation(), new Muddywater(), new Mudshot(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
		public override int Weight => 145;
		public override int ExpYield => 173;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}