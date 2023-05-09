using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Miltank : Pokemon
{
	public override string Name => "Miltank";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Scrappy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
	public override Stats BaseStats => new Stats(95, 80, 105, 40, 70, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[5] = new List<Move>() { new Moves.Rollout() },
		[10] = new List<Move>() { new Moves.Defensecurl() },
		[15] = new List<Move>() { new Moves.Stomp() },
		[20] = new List<Move>() { new Moves.Healbell() },
		[25] = new List<Move>() { new Moves.Headbutt() },
		[30] = new List<Move>() { new Moves.Zenheadbutt() },
		[35] = new List<Move>() { new Moves.Milkdrink() },
		[40] = new List<Move>() { new Moves.Bodyslam() },
		[45] = new List<Move>() { new Moves.Playrough() },
		[50] = new List<Move>() { new Moves.Charm() },
		[55] = new List<Move>() { new Moves.Highhorsepower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Hammerarm(), new Moves.Helpinghand(), new Moves.Present(), new Moves.Reversal(), new Moves.Seismictoss() };
	public override int Weight => 755;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}