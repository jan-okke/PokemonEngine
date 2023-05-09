using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Blastoise : Pokemon
{
	public override string Name => "Blastoise";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(79, 83, 100, 85, 105, 78);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Flashcannon() },
		[1] = new List<Move>() { new Moves.Flashcannon(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Watergun(), new Moves.Withdraw() },
		[9] = new List<Move>() { new Moves.Rapidspin() },
		[12] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Waterpulse() },
		[20] = new List<Move>() { new Moves.Protect() },
		[25] = new List<Move>() { new Moves.Raindance() },
		[30] = new List<Move>() { new Moves.Aquatail() },
		[35] = new List<Move>() { new Moves.Shellsmash() },
		[42] = new List<Move>() { new Moves.Irondefense() },
		[49] = new List<Move>() { new Moves.Hydropump() },
		[56] = new List<Move>() { new Moves.Skullbash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Flipturn(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydrocannon(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Terrainpulse(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 855;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}