using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Munchlax : Pokemon
{
	public override string Name => "Munchlax";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Thickfat() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
	public override Stats BaseStats => new Stats(135, 85, 40, 40, 85, 5);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Lick(), new Moves.Tackle() },
		[4] = new List<Move>() { new Moves.Defensecurl() },
		[8] = new List<Move>() { new Moves.Recycle() },
		[12] = new List<Move>() { new Moves.Covet() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Bodyslam() },
		[32] = new List<Move>() { new Moves.Fling() },
		[36] = new List<Move>() { new Moves.Amnesia() },
		[40] = new List<Move>() { new Moves.Metronome() },
		[44] = new List<Move>() { new Moves.Flail() },
		[48] = new List<Move>() { new Moves.Bellydrum() },
		[52] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Belch(), new Moves.Charm(), new Moves.Counter(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Lick(), new Moves.Selfdestruct(), new Moves.Whirlwind(), new Moves.Zenheadbutt() };
	public override int Weight => 1050;
	public override int ExpYield => 78;
	public override int CatchRate => 50;
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