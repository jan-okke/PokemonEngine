using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Manaphy : Pokemon
{
	public override string Name => "Manaphy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tailglow(), new Moves.Watergun() },
		[9] = new List<Move>() { new Moves.Charm() },
		[16] = new List<Move>() { new Moves.Supersonic() },
		[24] = new List<Move>() { new Moves.Bubblebeam() },
		[31] = new List<Move>() { new Moves.Acidarmor() },
		[39] = new List<Move>() { new Moves.Whirlpool() },
		[46] = new List<Move>() { new Moves.Waterpulse() },
		[54] = new List<Move>() { new Moves.Aquaring() },
		[61] = new List<Move>() { new Moves.Dive() },
		[69] = new List<Move>() { new Moves.Raindance() },
		[76] = new List<Move>() { new Moves.Heartswap() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override int Weight => 14;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}