using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Poipole : Pokemon
	{
		public override string Name => "Poipole";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
		public override Stats BaseStats => new Stats(67, 73, 67, 73, 67, 73);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Dragonpulse(), new Moves.Peck(), new Moves.Growl(), new Moves.Helpinghand(), new Moves.Acid() },
			[7] = new List<Move>() { new Moves.Furyattack() },
			[14] = new List<Move>() { new Moves.Fellstinger() },
			[21] = new List<Move>() { new Moves.Charm() },
			[28] = new List<Move>() { new Moves.Venoshock() },
			[35] = new List<Move>() { new Moves.Venomdrench() },
			[42] = new List<Move>() { new Moves.Nastyplot() },
			[49] = new List<Move>() { new Moves.Poisonjab() },
			[56] = new List<Move>() { new Moves.Gastroacid() },
			[63] = new List<Move>() { new Moves.Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Charm(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Nastyplot(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Venoshock() };
		public override int Weight => 18;
		public override int ExpYield => 210;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}