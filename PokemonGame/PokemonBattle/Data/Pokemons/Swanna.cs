using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Swanna : Pokemon
{
	public override string Name => "Swanna";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Bigpecks() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(75, 87, 63, 87, 63, 98);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Watersport(), new Moves.Defog(), new Moves.Wingattack() },
		[3] = new List<Move>() { new Moves.Watersport() },
		[6] = new List<Move>() { new Moves.Defog() },
		[9] = new List<Move>() { new Moves.Wingattack() },
		[13] = new List<Move>() { new Moves.Waterpulse() },
		[15] = new List<Move>() { new Moves.Aerialace() },
		[19] = new List<Move>() { new Moves.Bubblebeam() },
		[21] = new List<Move>() { new Moves.Featherdance() },
		[24] = new List<Move>() { new Moves.Aquaring() },
		[27] = new List<Move>() { new Moves.Airslash() },
		[30] = new List<Move>() { new Moves.Roost() },
		[34] = new List<Move>() { new Moves.Raindance() },
		[40] = new List<Move>() { new Moves.Tailwind() },
		[47] = new List<Move>() { new Moves.Bravebird() },
		[55] = new List<Move>() { new Moves.Hurricane() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Scald(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Waterpulse() };
	public override int Weight => 242;
	public override int ExpYield => 166;
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