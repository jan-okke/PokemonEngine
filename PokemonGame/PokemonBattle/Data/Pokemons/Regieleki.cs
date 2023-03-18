using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regieleki : Pokemon
	{
		public override string Name => "Regieleki";
		public override List<Ability> AvailableAbilities => new() {new Transistor() };
		public override Stats BaseStats => new Stats(80, 100, 50, 200, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Rapidspin() },
			[6] = new List<Move>() { new Electroweb() },
			[12] = new List<Move>() { new Ancientpower() },
			[18] = new List<Move>() { new Shockwave() },
			[24] = new List<Move>() { new Thunderwave() },
			[30] = new List<Move>() { new Extremespeed() },
			[36] = new List<Move>() { new Thundercage() },
			[42] = new List<Move>() { new Thunderbolt() },
			[48] = new List<Move>() { new Magnetrise() },
			[54] = new List<Move>() { new Thrash() },
			[60] = new List<Move>() { new Lockon() },
			[66] = new List<Move>() { new Zapcannon() },
			[72] = new List<Move>() { new Hyperbeam() },
			[78] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Bodyslam(), new Bounce(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Substitute(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 1450;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}