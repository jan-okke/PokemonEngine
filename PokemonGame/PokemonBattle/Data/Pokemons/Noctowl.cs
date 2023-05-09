using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Noctowl : Pokemon
{
	public override string Name => "Noctowl";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Keeneye() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tintedlens() };
	public override Stats BaseStats => new Stats(100, 50, 50, 86, 96, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Skyattack(), new Moves.Peck(), new Moves.Growl(), new Moves.Tackle(), new Moves.Echoedvoice() },
		[9] = new List<Move>() { new Moves.Confusion() },
		[12] = new List<Move>() { new Moves.Reflect() },
		[15] = new List<Move>() { new Moves.Psychoshift() },
		[18] = new List<Move>() { new Moves.Airslash() },
		[23] = new List<Move>() { new Moves.Extrasensory() },
		[28] = new List<Move>() { new Moves.Takedown() },
		[33] = new List<Move>() { new Moves.Uproar() },
		[38] = new List<Move>() { new Moves.Roost() },
		[43] = new List<Move>() { new Moves.Moonblast() },
		[48] = new List<Move>() { new Moves.Hypnosis() },
		[53] = new List<Move>() { new Moves.Dreameater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Nastyplot(), new Moves.Pluck(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 408;
	public override int ExpYield => 158;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}