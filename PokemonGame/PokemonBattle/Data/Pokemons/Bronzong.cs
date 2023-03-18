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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate(), new Abilities.Heatproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
		public override Stats BaseStats => new Stats(67, 89, 116, 79, 116, 33);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Block() },
			[1] = new List<Move>() { new Moves.Block(), new Moves.Sunnyday(), new Moves.Weatherball(), new Moves.Tackle(), new Moves.Confusion(), new Moves.Confuseray(), new Moves.Payback() },
			[12] = new List<Move>() { new Moves.Imprison() },
			[16] = new List<Move>() { new Moves.Gyroball() },
			[20] = new List<Move>() { new Moves.Hypnosis() },
			[24] = new List<Move>() { new Moves.Safeguard() },
			[28] = new List<Move>() { new Moves.Extrasensory() },
			[32] = new List<Move>() { new Moves.Heavyslam() },
			[38] = new List<Move>() { new Moves.Irondefense() },
			[44] = new List<Move>() { new Moves.Metalsound() },
			[50] = new List<Move>() { new Moves.Futuresight() },
			[56] = new List<Move>() { new Moves.Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bodypress(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Weatherball(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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