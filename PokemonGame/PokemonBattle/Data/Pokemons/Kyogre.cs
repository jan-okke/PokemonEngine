using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kyogre : Pokemon
{
	public override string Name => "Kyogre";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Drizzle() };
	public override Stats BaseStats => new Stats(100, 100, 90, 150, 140, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Waterpulse(), new Moves.Ancientpower(), new Moves.Bodyslam(), new Moves.Scaryface() },
		[9] = new List<Move>() { new Moves.Aquatail() },
		[18] = new List<Move>() { new Moves.Calmmind() },
		[27] = new List<Move>() { new Moves.Muddywater() },
		[36] = new List<Move>() { new Moves.Icebeam() },
		[45] = new List<Move>() { new Moves.Sheercold() },
		[54] = new List<Move>() { new Moves.Aquaring() },
		[63] = new List<Move>() { new Moves.Originpulse() },
		[72] = new List<Move>() { new Moves.Hydropump() },
		[81] = new List<Move>() { new Moves.Doubleedge() },
		[90] = new List<Move>() { new Moves.Waterspout() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Scaryface(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 3520;
	public override int ExpYield => 335;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}