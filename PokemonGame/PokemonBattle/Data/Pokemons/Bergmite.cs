using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bergmite : Pokemon
{
	public override string Name => "Bergmite";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Icebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(55, 69, 85, 32, 35, 28);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rapidspin(), new Moves.Harden() },
		[3] = new List<Move>() { new Moves.Tackle() },
		[6] = new List<Move>() { new Moves.Powdersnow() },
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
		[39] = new List<Move>() { new Moves.Blizzard() },
		[42] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Auroraveil(), new Moves.Mirrorcoat(), new Moves.Mist() };
	public override int Weight => 995;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}