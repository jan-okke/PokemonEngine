using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Metang : Pokemon
{
	public override string Name => "Metang";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightmetal() };
	public override Stats BaseStats => new Stats(60, 75, 100, 55, 80, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Confusion(), new Moves.Metalclaw() },
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Metalclaw(), new Moves.Bulletpunch(), new Moves.Tackle() },
		[6] = new List<Move>() { new Moves.Zenheadbutt() },
		[12] = new List<Move>() { new Moves.Magnetrise() },
		[18] = new List<Move>() { new Moves.Flashcannon() },
		[26] = new List<Move>() { new Moves.Takedown() },
		[34] = new List<Move>() { new Moves.Psychic() },
		[42] = new List<Move>() { new Moves.Scaryface() },
		[50] = new List<Move>() { new Moves.Meteormash() },
		[58] = new List<Move>() { new Moves.Irondefense() },
		[66] = new List<Move>() { new Moves.Agility() },
		[74] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Cosmicpower(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderpunch(), new Moves.Trick(), new Moves.Zenheadbutt() };
	public override int Weight => 2025;
	public override int ExpYield => 147;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}