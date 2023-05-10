using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lugia : Pokemon
{
	public override string Name => "Lugia";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Multiscale() };
	public override Stats BaseStats => new Stats(106, 90, 130, 90, 154, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Dragonrush(), new Moves.Gust(), new Moves.Whirlwind(), new Moves.Weatherball(), new Moves.Ancientpower() },
		[9] = new List<Move>() { new Moves.Mist() },
		[18] = new List<Move>() { new Moves.Safeguard() },
		[27] = new List<Move>() { new Moves.Calmmind() },
		[36] = new List<Move>() { new Moves.Extrasensory() },
		[45] = new List<Move>() { new Moves.Recover() },
		[54] = new List<Move>() { new Moves.Aeroblast() },
		[63] = new List<Move>() { new Moves.Raindance() },
		[72] = new List<Move>() { new Moves.Hydropump() },
		[81] = new List<Move>() { new Moves.Futuresight() },
		[90] = new List<Move>() { new Moves.Skyattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fly(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 2160;
	public override int ExpYield => 340;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}