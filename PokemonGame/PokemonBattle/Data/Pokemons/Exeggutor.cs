using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Exeggutor : Pokemon
	{
		public override string Name => "Exeggutor";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Harvest() };
		public override Stats BaseStats => new Stats(95, 95, 85, 125, 75, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Stomp() },
			[1] = new List<Move>() { new Stomp(), new Seedbomb(), new Psyshock(), new Woodhammer(), new Leafstorm(), new Megadrain(), new Confusion(), new Synthesis(), new Bulletseed(), new Gigadrain(), new Extrasensory(), new Uproar(), new Worryseed(), new Solarbeam(), new Absorb(), new Hypnosis(), new Reflect(), new Leechseed() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulldoze(), new Bulletseed(), new Calmmind(), new Doubleteam(), new Dreameater(), new Endure(), new Energyball(), new Expandingforce(), new Explosion(), new Facade(), new Flash(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Leafstorm(), new Lightscreen(), new Lowkick(), new Magicalleaf(), new Powerswap(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Seedbomb(), new Selfdestruct(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Terrainpulse(), new Thief(), new Trickroom(), new Uproar(), new Zenheadbutt() };
		public override int Weight => 1200;
		public override int ExpYield => 186;
		public override int CatchRate => 45;
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