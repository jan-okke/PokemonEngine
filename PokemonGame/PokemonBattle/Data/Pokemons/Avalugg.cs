using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Avalugg : Pokemon
{
	public override string Name => "Avalugg";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Icebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(95, 117, 184, 44, 46, 28);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Bodyslam() },
		[1] = new List<Move>() { new Moves.Bodyslam(), new Moves.Wideguard(), new Moves.Rapidspin(), new Moves.Harden(), new Moves.Tackle(), new Moves.Powdersnow() },
		[9] = new List<Move>() { new Moves.Curse() },
		[12] = new List<Move>() { new Moves.Icywind() },
		[15] = new List<Move>() { new Moves.Protect() },
		[18] = new List<Move>() { new Moves.Avalanche() },
		[21] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Icefang() },
		[27] = new List<Move>() { new Moves.Irondefense() },
		[30] = new List<Move>() { new Moves.Recover() },
		[33] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[41] = new List<Move>() { new Moves.Blizzard() },
		[46] = new List<Move>() { new Moves.Doubleedge() },
		[51] = new List<Move>() { new Moves.Skullbash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf() };
	public override int Weight => 5050;
	public override int ExpYield => 180;
	public override int CatchRate => 55;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}