using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Scorbunny : Pokemon
{
	public override string Name => "Scorbunny";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Libero() };
	public override Stats BaseStats => new Stats(50, 71, 40, 40, 40, 69);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[6] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Doublekick() },
		[17] = new List<Move>() { new Moves.Flamecharge() },
		[20] = new List<Move>() { new Moves.Agility() },
		[24] = new List<Move>() { new Moves.Headbutt() },
		[28] = new List<Move>() { new Moves.Counter() },
		[32] = new List<Move>() { new Moves.Bounce() },
		[36] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blazekick(), new Moves.Bounce(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepledge(), new Moves.Flamethrower(), new Moves.Focusenergy(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Mudshot(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Highjumpkick(), new Moves.Sandattack(), new Moves.Suckerpunch(), new Moves.Superfang() };
	public override int Weight => 45;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
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