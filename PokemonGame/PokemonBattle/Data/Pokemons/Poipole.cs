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
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(67, 73, 67, 73, 73, 67);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonpulse(), new Peck(), new Growl(), new Helpinghand(), new Acid() },
			[7] = new List<Move>() { new Furyattack() },
			[14] = new List<Move>() { new Fellstinger() },
			[21] = new List<Move>() { new Charm() },
			[28] = new List<Move>() { new Venoshock() },
			[35] = new List<Move>() { new Venomdrench() },
			[42] = new List<Move>() { new Nastyplot() },
			[49] = new List<Move>() { new Poisonjab() },
			[56] = new List<Move>() { new Gastroacid() },
			[63] = new List<Move>() { new Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Charm(), new Dragonpulse(), new Endure(), new Facade(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Nastyplot(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Toxicspikes(), new Uproar(), new Venomdrench(), new Venoshock() };
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