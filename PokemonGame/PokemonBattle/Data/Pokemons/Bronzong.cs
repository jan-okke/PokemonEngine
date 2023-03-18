using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bronzong : Pokemon
	{
		public override string Name => "Bronzong";
		public override List<Ability> AvailableAbilities => new() {new Levitate(), new Heatproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(67, 89, 116, 79, 116, 33);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Block() },
			[1] = new List<Move>() { new Block(), new Sunnyday(), new Weatherball(), new Tackle(), new Confusion(), new Confuseray(), new Payback() },
			[12] = new List<Move>() { new Imprison() },
			[16] = new List<Move>() { new Gyroball() },
			[20] = new List<Move>() { new Hypnosis() },
			[24] = new List<Move>() { new Safeguard() },
			[28] = new List<Move>() { new Extrasensory() },
			[32] = new List<Move>() { new Heavyslam() },
			[38] = new List<Move>() { new Irondefense() },
			[44] = new List<Move>() { new Metalsound() },
			[50] = new List<Move>() { new Futuresight() },
			[56] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodypress(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Expandingforce(), new Explosion(), new Facade(), new Flash(), new Flashcannon(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Gyroball(), new Heavyslam(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irondefense(), new Ironhead(), new Lightscreen(), new Meteorbeam(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Trick(), new Trickroom(), new Weatherball(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 1870;
		public override int ExpYield => 175;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}