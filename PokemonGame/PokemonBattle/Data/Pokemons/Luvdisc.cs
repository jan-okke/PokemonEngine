using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Luvdisc : Pokemon
{
	public override string Name => "Luvdisc";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(43, 30, 55, 40, 65, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Charm() },
		[4] = new List<Move>() { new Moves.Watergun() },
		[7] = new List<Move>() { new Moves.Agility() },
		[9] = new List<Move>() { new Moves.Drainingkiss() },
		[13] = new List<Move>() { new Moves.Tearfullook() },
		[17] = new List<Move>() { new Moves.Waterpulse() },
		[20] = new List<Move>() { new Moves.Attract() },
		[22] = new List<Move>() { new Moves.Brine() },
		[26] = new List<Move>() { new Moves.Flail() },
		[31] = new List<Move>() { new Moves.Sweetkiss() },
		[34] = new List<Move>() { new Moves.Takedown() },
		[37] = new List<Move>() { new Moves.Babydolleyes() },
		[40] = new List<Move>() { new Moves.Aquaring() },
		[42] = new List<Move>() { new Moves.Soak() },
		[46] = new List<Move>() { new Moves.Hydropump() },
		[49] = new List<Move>() { new Moves.Safeguard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Aquaring(), new Moves.Entrainment(), new Moves.Healpulse(), new Moves.Splash(), new Moves.Supersonic() };
	public override int Weight => 87;
	public override int ExpYield => 116;
	public override int CatchRate => 225;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}