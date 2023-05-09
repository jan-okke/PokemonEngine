using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Phione : Pokemon
{
	public override string Name => "Phione";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(80, 80, 80, 80, 80, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun() },
		[9] = new List<Move>() { new Moves.Charm() },
		[16] = new List<Move>() { new Moves.Supersonic() },
		[24] = new List<Move>() { new Moves.Bubblebeam() },
		[31] = new List<Move>() { new Moves.Acidarmor() },
		[39] = new List<Move>() { new Moves.Whirlpool() },
		[46] = new List<Move>() { new Moves.Waterpulse() },
		[54] = new List<Move>() { new Moves.Aquaring() },
		[61] = new List<Move>() { new Moves.Dive() },
		[69] = new List<Move>() { new Moves.Raindance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override int Weight => 31;
	public override int ExpYield => 240;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}