using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Surskit : Pokemon
{
	public override string Name => "Surskit";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(40, 30, 32, 50, 52, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Sweetscent() },
		[14] = new List<Move>() { new Moves.Soak() },
		[17] = new List<Move>() { new Moves.Bubblebeam() },
		[22] = new List<Move>() { new Moves.Agility() },
		[25] = new List<Move>() { new Moves.Mist(), new Moves.Haze() },
		[30] = new List<Move>() { new Moves.Aquajet() },
		[35] = new List<Move>() { new Moves.Batonpass() },
		[38] = new List<Move>() { new Moves.Stickyweb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bugbite(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Infestation(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Bugbite(), new Moves.Fellstinger(), new Moves.Hydropump(), new Moves.Lunge(), new Moves.Mindreader(), new Moves.Mudshot(), new Moves.Powersplit(), new Moves.Psybeam() };
	public override int Weight => 17;
	public override int ExpYield => 54;
	public override int CatchRate => 200;
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