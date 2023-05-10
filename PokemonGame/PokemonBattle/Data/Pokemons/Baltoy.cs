using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Baltoy : Pokemon
{
	public override string Name => "Baltoy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(40, 40, 55, 40, 70, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Harden(), new Moves.Mudslap() },
		[3] = new List<Move>() { new Moves.Rapidspin() },
		[6] = new List<Move>() { new Moves.Confusion() },
		[9] = new List<Move>() { new Moves.Rocktomb() },
		[12] = new List<Move>() { new Moves.Powertrick() },
		[15] = new List<Move>() { new Moves.Psybeam() },
		[18] = new List<Move>() { new Moves.Ancientpower() },
		[21] = new List<Move>() { new Moves.Imprison() },
		[24] = new List<Move>() { new Moves.Cosmicpower() },
		[27] = new List<Move>() { new Moves.Extrasensory() },
		[30] = new List<Move>() { new Moves.Earthpower() },
		[33] = new List<Move>() { new Moves.Selfdestruct() },
		[36] = new List<Move>() { new Moves.Guardsplit(), new Moves.Powersplit() },
		[39] = new List<Move>() { new Moves.Sandstorm() },
		[42] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Eerieimpulse(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 215;
	public override int ExpYield => 60;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}