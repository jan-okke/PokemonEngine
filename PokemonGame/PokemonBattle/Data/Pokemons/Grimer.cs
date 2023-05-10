using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Grimer : Pokemon
{
	public override string Name => "Grimer";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stench(), new Abilities.Stickyhold() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Poisontouch() };
	public override Stats BaseStats => new Stats(80, 80, 50, 40, 50, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Poisongas() },
		[4] = new List<Move>() { new Moves.Harden() },
		[7] = new List<Move>() { new Moves.Mudslap() },
		[12] = new List<Move>() { new Moves.Disable() },
		[15] = new List<Move>() { new Moves.Sludge() },
		[18] = new List<Move>() { new Moves.Smog() },
		[21] = new List<Move>() { new Moves.Minimize() },
		[26] = new List<Move>() { new Moves.Fling() },
		[29] = new List<Move>() { new Moves.Sludgebomb() },
		[32] = new List<Move>() { new Moves.Sludgewave() },
		[37] = new List<Move>() { new Moves.Screech() },
		[40] = new List<Move>() { new Moves.Gunkshot() },
		[43] = new List<Move>() { new Moves.Acidarmor() },
		[46] = new List<Move>() { new Moves.Belch() },
		[48] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Curse(), new Moves.Haze(), new Moves.Imprison(), new Moves.Lick(), new Moves.Meanlook(), new Moves.Poweruppunch(), new Moves.Scaryface(), new Moves.Shadowpunch(), new Moves.Shadowsneak(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
	public override int Weight => 300;
	public override int ExpYield => 65;
	public override int CatchRate => 190;
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