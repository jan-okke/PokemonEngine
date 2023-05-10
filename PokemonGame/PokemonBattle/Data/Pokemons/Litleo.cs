using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Litleo : Pokemon
{
	public override string Name => "Litleo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rivalry(), new Abilities.Unnerve() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
	public override Stats BaseStats => new Stats(62, 50, 58, 73, 54, 72);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Workup() },
		[11] = new List<Move>() { new Moves.Headbutt() },
		[15] = new List<Move>() { new Moves.Nobleroar() },
		[20] = new List<Move>() { new Moves.Takedown() },
		[23] = new List<Move>() { new Moves.Firefang() },
		[28] = new List<Move>() { new Moves.Endeavor() },
		[33] = new List<Move>() { new Moves.Echoedvoice() },
		[36] = new List<Move>() { new Moves.Flamethrower() },
		[39] = new List<Move>() { new Moves.Crunch() },
		[43] = new List<Move>() { new Moves.Hypervoice() },
		[46] = new List<Move>() { new Moves.Incinerate() },
		[50] = new List<Move>() { new Moves.Overheat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Entrainment(), new Moves.Firespin(), new Moves.Flareblitz(), new Moves.Snatch(), new Moves.Yawn() };
	public override int Weight => 135;
	public override int ExpYield => 74;
	public override int CatchRate => 220;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}