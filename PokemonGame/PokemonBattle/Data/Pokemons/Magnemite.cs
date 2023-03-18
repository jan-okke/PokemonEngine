using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magnemite : Pokemon
	{
		public override string Name => "Magnemite";
		public override List<Ability> AvailableAbilities => new() {new Magnetpull(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(25, 35, 70, 95, 55, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Tackle() },
			[4] = new List<Move>() { new Supersonic() },
			[8] = new List<Move>() { new Thunderwave() },
			[12] = new List<Move>() { new Electroball() },
			[16] = new List<Move>() { new Gyroball() },
			[20] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Magnetrise() },
			[32] = new List<Move>() { new Flashcannon() },
			[36] = new List<Move>() { new Discharge() },
			[40] = new List<Move>() { new Metalsound() },
			[44] = new List<Move>() { new Lightscreen() },
			[48] = new List<Move>() { new Lockon() },
			[52] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Chargebeam(), new Doubleteam(), new Electroball(), new Electroweb(), new Endure(), new Explosion(), new Facade(), new Flash(), new Flashcannon(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Protect(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 60;
		public override int ExpYield => 65;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}