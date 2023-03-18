using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Weezing : Pokemon
	{
		public override string Name => "Weezing";
		public override List<Ability> AvailableAbilities => new() {new Levitate(), new Neutralizinggas() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stench() };
		public override Stats BaseStats => new Stats(65, 90, 120, 85, 70, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Doublehit() },
			[1] = new List<Move>() { new Doublehit(), new Heatwave(), new Poisongas(), new Tackle(), new Smog(), new Smokescreen() },
			[12] = new List<Move>() { new Clearsmog() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Sludge() },
			[24] = new List<Move>() { new Haze() },
			[28] = new List<Move>() { new Selfdestruct() },
			[32] = new List<Move>() { new Sludgebomb() },
			[38] = new List<Move>() { new Toxic() },
			[44] = new List<Move>() { new Belch() },
			[50] = new List<Move>() { new Explosion() },
			[56] = new List<Move>() { new Memento() },
			[62] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Corrosivegas(), new Darkpulse(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Gigaimpact(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Payback(), new Protect(), new Raindance(), new Rest(), new Round(), new Screech(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Torment(), new Toxic(), new Toxicspikes(), new Uproar(), new Venomdrench(), new Venoshock(), new Willowisp() };
		public override int Weight => 95;
		public override int ExpYield => 172;
		public override int CatchRate => 60;
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