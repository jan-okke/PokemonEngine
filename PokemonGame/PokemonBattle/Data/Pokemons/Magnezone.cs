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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Magnetpull(), new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
		public override Stats BaseStats => new Stats(70, 70, 115, 130, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Triattack(), new Moves.Electricterrain(), new Moves.Magneticflux(), new Moves.Mirrorcoat(), new Moves.Thundershock(), new Moves.Tackle(), new Moves.Supersonic(), new Moves.Thunderwave() },
			[12] = new List<Move>() { new Moves.Electroball() },
			[16] = new List<Move>() { new Moves.Gyroball() },
			[20] = new List<Move>() { new Moves.Spark() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Magnetrise() },
			[34] = new List<Move>() { new Moves.Flashcannon() },
			[40] = new List<Move>() { new Moves.Discharge() },
			[46] = new List<Move>() { new Moves.Metalsound() },
			[52] = new List<Move>() { new Moves.Lightscreen() },
			[58] = new List<Move>() { new Moves.Lockon() },
			[64] = new List<Move>() { new Moves.Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bodypress(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Voltswitch(), new Moves.Wildcharge() };
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