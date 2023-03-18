using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magnezone : Pokemon
	{
		public override string Name => "Magnezone";
		public override List<Ability> AvailableAbilities => new() {new Magnetpull(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(70, 70, 115, 60, 130, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Triattack(), new Electricterrain(), new Magneticflux(), new Mirrorcoat(), new Thundershock(), new Tackle(), new Supersonic(), new Thunderwave() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodypress(), new Chargebeam(), new Doubleteam(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Explosion(), new Facade(), new Flash(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lightscreen(), new Protect(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Selfdestruct(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelroller(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 1800;
		public override int ExpYield => 268;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}