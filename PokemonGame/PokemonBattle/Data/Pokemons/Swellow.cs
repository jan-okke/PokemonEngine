using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Swellow : Pokemon
{
	public override string Name => "Swellow";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
	public override Stats BaseStats => new Stats(60, 85, 60, 75, 50, 125);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bravebird(), new Moves.Airslash(), new Moves.Pluck(), new Moves.Peck(), new Moves.Growl(), new Moves.Focusenergy(), new Moves.Quickattack() },
		[5] = new List<Move>() { new Moves.Focusenergy() },
		[9] = new List<Move>() { new Moves.Quickattack() },
		[13] = new List<Move>() { new Moves.Wingattack() },
		[17] = new List<Move>() { new Moves.Doubleteam() },
		[21] = new List<Move>() { new Moves.Aerialace() },
		[27] = new List<Move>() { new Moves.Quickguard() },
		[33] = new List<Move>() { new Moves.Agility() },
		[39] = new List<Move>() { new Moves.Airslash() },
		[45] = new List<Move>() { new Moves.Endeavor() },
		[51] = new List<Move>() { new Moves.Bravebird() },
		[57] = new List<Move>() { new Moves.Reversal() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Laserfocus(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 198;
	public override int ExpYield => 159;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}