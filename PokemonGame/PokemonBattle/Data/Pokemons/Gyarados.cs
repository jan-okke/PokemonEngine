using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gyarados : Pokemon
{
	public override string Name => "Gyarados";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
	public override Stats BaseStats => new Stats(95, 125, 79, 60, 100, 81);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Bite() },
		[1] = new List<Move>() { new Moves.Bite(), new Moves.Flail(), new Moves.Splash(), new Moves.Tackle(), new Moves.Leer(), new Moves.Twister() },
		[4] = new List<Move>() { new Moves.Whirlpool() },
		[8] = new List<Move>() { new Moves.Icefang() },
		[12] = new List<Move>() { new Moves.Brine() },
		[16] = new List<Move>() { new Moves.Scaryface() },
		[21] = new List<Move>() { new Moves.Waterfall() },
		[24] = new List<Move>() { new Moves.Crunch() },
		[28] = new List<Move>() { new Moves.Raindance() },
		[32] = new List<Move>() { new Moves.Aquatail() },
		[36] = new List<Move>() { new Moves.Dragondance() },
		[40] = new List<Move>() { new Moves.Hydropump() },
		[44] = new List<Move>() { new Moves.Hurricane() },
		[48] = new List<Move>() { new Moves.Thrash() },
		[52] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Payback(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 2350;
	public override int ExpYield => 189;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}