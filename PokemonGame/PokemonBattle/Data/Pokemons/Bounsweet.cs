using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bounsweet : Pokemon
{
	public override string Name => "Bounsweet";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard(), new Abilities.Oblivious() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sweetveil() };
	public override Stats BaseStats => new Stats(42, 30, 38, 30, 38, 32);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash() },
		[4] = new List<Move>() { new Moves.Playnice() },
		[8] = new List<Move>() { new Moves.Rapidspin() },
		[12] = new List<Move>() { new Moves.Razorleaf() },
		[16] = new List<Move>() { new Moves.Sweetscent() },
		[20] = new List<Move>() { new Moves.Magicalleaf() },
		[24] = new List<Move>() { new Moves.Flail() },
		[28] = new List<Move>() { new Moves.Teeterdance() },
		[32] = new List<Move>() { new Moves.Aromaticmist() },
		[36] = new List<Move>() { new Moves.Aromatherapy() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Playrough(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acupressure(), new Moves.Endeavor(), new Moves.Synthesis() };
	public override int Weight => 32;
	public override int ExpYield => 42;
	public override int CatchRate => 235;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}