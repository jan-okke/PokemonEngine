using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Baltoy : Pokemon
	{
		public override string Name => "Baltoy";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(40, 40, 55, 40, 70, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Harden(), new Mudslap() },
			[3] = new List<Move>() { new Rapidspin() },
			[6] = new List<Move>() { new Confusion() },
			[9] = new List<Move>() { new Rocktomb() },
			[12] = new List<Move>() { new Powertrick() },
			[15] = new List<Move>() { new Psybeam() },
			[18] = new List<Move>() { new Ancientpower() },
			[21] = new List<Move>() { new Imprison() },
			[24] = new List<Move>() { new Cosmicpower() },
			[27] = new List<Move>() { new Extrasensory() },
			[30] = new List<Move>() { new Earthpower() },
			[33] = new List<Move>() { new Selfdestruct() },
			[36] = new List<Move>() { new Guardsplit(), new Powersplit() },
			[39] = new List<Move>() { new Sandstorm() },
			[42] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Cosmicpower(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Dreameater(), new Drillrun(), new Earthpower(), new Earthquake(), new Eerieimpulse(), new Endure(), new Expandingforce(), new Explosion(), new Facade(), new Flash(), new Grassknot(), new Guardswap(), new Gyroball(), new Hex(), new Hiddenpower(), new Icebeam(), new Imprison(), new Lightscreen(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Selfdestruct(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Substitute(), new Sunnyday(), new Swagger(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 215;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}