using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gulpin : Pokemon
{
	public override string Name => "Gulpin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Liquidooze(), new Abilities.Stickyhold() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
	public override Stats BaseStats => new Stats(70, 43, 53, 43, 53, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound() },
		[5] = new List<Move>() { new Moves.Yawn() },
		[8] = new List<Move>() { new Moves.Poisongas() },
		[10] = new List<Move>() { new Moves.Sludge() },
		[12] = new List<Move>() { new Moves.Amnesia() },
		[17] = new List<Move>() { new Moves.Acidspray() },
		[20] = new List<Move>() { new Moves.Encore() },
		[25] = new List<Move>() { new Moves.Toxic() },
		[28] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
		[33] = new List<Move>() { new Moves.Sludgebomb() },
		[36] = new List<Move>() { new Moves.Gastroacid() },
		[41] = new List<Move>() { new Moves.Belch() },
		[44] = new List<Move>() { new Moves.Painsplit() },
		[49] = new List<Move>() { new Moves.Gunkshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Painsplit(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Venoshock(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Curse(), new Moves.Destinybond(), new Moves.Gunkshot(), new Moves.Mudslap(), new Moves.Painsplit(), new Moves.Smog(), new Moves.Venomdrench() };
	public override int Weight => 103;
	public override int ExpYield => 60;
	public override int CatchRate => 225;
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