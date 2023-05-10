using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Trubbish : Pokemon
{
	public override string Name => "Trubbish";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stench(), new Abilities.Stickyhold() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aftermath() };
	public override Stats BaseStats => new Stats(50, 50, 62, 40, 62, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Poisongas() },
		[3] = new List<Move>() { new Moves.Recycle() },
		[6] = new List<Move>() { new Moves.Acidspray() },
		[9] = new List<Move>() { new Moves.Amnesia() },
		[12] = new List<Move>() { new Moves.Clearsmog() },
		[15] = new List<Move>() { new Moves.Toxicspikes() },
		[18] = new List<Move>() { new Moves.Sludge() },
		[21] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow() },
		[24] = new List<Move>() { new Moves.Takedown() },
		[27] = new List<Move>() { new Moves.Sludgebomb() },
		[30] = new List<Move>() { new Moves.Toxic() },
		[33] = new List<Move>() { new Moves.Belch() },
		[37] = new List<Move>() { new Moves.Painsplit() },
		[39] = new List<Move>() { new Moves.Gunkshot() },
		[42] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Corrosivegas(), new Moves.Darkpulse(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Autotomize(), new Moves.Curse(), new Moves.Haze(), new Moves.Rollout(), new Moves.Sandattack() };
	public override int Weight => 310;
	public override int ExpYield => 66;
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