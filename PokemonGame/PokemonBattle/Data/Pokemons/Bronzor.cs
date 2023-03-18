using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bronzor : Pokemon
	{
		public override string Name => "Bronzor";
		public override List<Ability> AvailableAbilities => new() {new Levitate(), new Heatproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(57, 24, 86, 23, 24, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Confusion() },
			[4] = new List<Move>() { new Confuseray() },
			[8] = new List<Move>() { new Payback() },
			[12] = new List<Move>() { new Imprison() },
			[16] = new List<Move>() { new Gyroball() },
			[20] = new List<Move>() { new Hypnosis() },
			[24] = new List<Move>() { new Safeguard() },
			[28] = new List<Move>() { new Extrasensory() },
			[32] = new List<Move>() { new Heavyslam() },
			[36] = new List<Move>() { new Irondefense() },
			[40] = new List<Move>() { new Metalsound() },
			[44] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Expandingforce(), new Facade(), new Flash(), new Flashcannon(), new Futuresight(), new Grassknot(), new Guardswap(), new Gyroball(), new Heavyslam(), new Hex(), new Hiddenpower(), new Imprison(), new Irondefense(), new Lightscreen(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Substitute(), new Sunnyday(), new Swagger(), new Trick(), new Trickroom(), new Wonderroom() };
		public override int Weight => 605;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
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