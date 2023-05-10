using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Alomomola : Pokemon
{
	public override string Name => "Alomomola";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Healer(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(165, 75, 80, 40, 45, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Playnice(), new Moves.Hydropump(), new Moves.Wideguard(), new Moves.Healingwish(), new Moves.Helpinghand(), new Moves.Pound(), new Moves.Watersport() },
		[5] = new List<Move>() { new Moves.Aquaring() },
		[9] = new List<Move>() { new Moves.Aquajet() },
		[13] = new List<Move>() { new Moves.Doubleslap() },
		[17] = new List<Move>() { new Moves.Healpulse() },
		[21] = new List<Move>() { new Moves.Protect() },
		[25] = new List<Move>() { new Moves.Waterpulse() },
		[29] = new List<Move>() { new Moves.Wakeupslap() },
		[33] = new List<Move>() { new Moves.Soak() },
		[37] = new List<Move>() { new Moves.Wish() },
		[41] = new List<Move>() { new Moves.Brine() },
		[45] = new List<Move>() { new Moves.Safeguard() },
		[49] = new List<Move>() { new Moves.Whirlpool() },
		[53] = new List<Move>() { new Moves.Helpinghand() },
		[57] = new List<Move>() { new Moves.Healingwish() },
		[61] = new List<Move>() { new Moves.Wideguard() },
		[65] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Facade(), new Moves.Frustration(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Magiccoat(), new Moves.Painsplit(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Toxic(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Endure(), new Moves.Mirrorcoat(), new Moves.Mist(), new Moves.Painsplit(), new Moves.Refresh(), new Moves.Tickle() };
	public override int Weight => 316;
	public override int ExpYield => 165;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}