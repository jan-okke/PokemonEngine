using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magneton : Pokemon
	{
		public override string Name => "Magneton";
		public override List<Ability> AvailableAbilities => new() {new Magnetpull(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(50, 60, 95, 120, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Triattack() },
			[1] = new List<Move>() { new Triattack(), new Electricterrain(), new Thundershock(), new Tackle(), new Supersonic(), new Thunderwave() },
			[12] = new List<Move>() { new Electroball() },
			[16] = new List<Move>() { new Gyroball() },
			[20] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Magnetrise() },
			[34] = new List<Move>() { new Flashcannon() },
			[40] = new List<Move>() { new Discharge() },
			[46] = new List<Move>() { new Metalsound() },
			[52] = new List<Move>() { new Lightscreen() },
			[58] = new List<Move>() { new Lockon() },
			[64] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Chargebeam(), new Doubleteam(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Explosion(), new Facade(), new Flash(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Protect(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 600;
		public override int ExpYield => 163;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}