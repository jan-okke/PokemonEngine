using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Koffing : Pokemon
	{
		public override string Name => "Koffing";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate(), new Abilities.Neutralizinggas() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stench() };
		public override Stats BaseStats => new Stats(40, 65, 95, 60, 45, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisongas(), new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Smog() },
			[8] = new List<Move>() { new Moves.Smokescreen() },
			[12] = new List<Move>() { new Moves.Clearsmog() },
			[16] = new List<Move>() { new Moves.Assurance() },
			[20] = new List<Move>() { new Moves.Sludge() },
			[24] = new List<Move>() { new Moves.Haze() },
			[28] = new List<Move>() { new Moves.Selfdestruct() },
			[32] = new List<Move>() { new Moves.Sludgebomb() },
			[36] = new List<Move>() { new Moves.Toxic() },
			[40] = new List<Move>() { new Moves.Belch() },
			[44] = new List<Move>() { new Moves.Explosion() },
			[48] = new List<Move>() { new Moves.Memento() },
			[52] = new List<Move>() { new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Corrosivegas(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Torment(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Destinybond(), new Moves.Grudge(), new Moves.Painsplit(), new Moves.Psybeam(), new Moves.Screech(), new Moves.Spite(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Toxicspikes(), new Moves.Venomdrench() };
		public override int Weight => 10;
		public override int ExpYield => 68;
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