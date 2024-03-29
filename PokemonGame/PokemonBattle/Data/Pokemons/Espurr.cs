using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Espurr : Pokemon
{
	public override string Name => "Espurr";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Infiltrator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Owntempo() };
	public override Stats BaseStats => new Stats(62, 48, 54, 63, 60, 68);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
		[3] = new List<Move>() { new Moves.Fakeout() },
		[6] = new List<Move>() { new Moves.Disarmingvoice() },
		[9] = new List<Move>() { new Moves.Confusion() },
		[18] = new List<Move>() { new Moves.Covet() },
		[21] = new List<Move>() { new Moves.Psybeam() },
		[30] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
		[33] = new List<Move>() { new Moves.Psyshock() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Tickle(), new Moves.Yawn() };
	public override int Weight => 35;
	public override int ExpYield => 71;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}