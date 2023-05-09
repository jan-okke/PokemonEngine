using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Exeggutor : Pokemon
{
	public override string Name => "Exeggutor";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Harvest() };
	public override Stats BaseStats => new Stats(95, 95, 85, 125, 75, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Stomp() },
		[1] = new List<Move>() { new Moves.Stomp(), new Moves.Seedbomb(), new Moves.Psyshock(), new Moves.Woodhammer(), new Moves.Leafstorm(), new Moves.Megadrain(), new Moves.Confusion(), new Moves.Synthesis(), new Moves.Bulletseed(), new Moves.Gigadrain(), new Moves.Extrasensory(), new Moves.Uproar(), new Moves.Worryseed(), new Moves.Solarbeam(), new Moves.Absorb(), new Moves.Hypnosis(), new Moves.Reflect(), new Moves.Leechseed() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Thief(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Zenheadbutt() };
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