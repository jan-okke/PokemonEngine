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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Magnetpull(), new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
		public override Stats BaseStats => new Stats(25, 35, 70, 95, 55, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Supersonic() },
			[8] = new List<Move>() { new Moves.Thunderwave() },
			[12] = new List<Move>() { new Moves.Electroball() },
			[16] = new List<Move>() { new Moves.Gyroball() },
			[20] = new List<Move>() { new Moves.Spark() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Magnetrise() },
			[32] = new List<Move>() { new Moves.Flashcannon() },
			[36] = new List<Move>() { new Moves.Discharge() },
			[40] = new List<Move>() { new Moves.Metalsound() },
			[44] = new List<Move>() { new Moves.Lightscreen() },
			[48] = new List<Move>() { new Moves.Lockon() },
			[52] = new List<Move>() { new Moves.Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
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