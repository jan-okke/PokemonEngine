using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Relicanth : Pokemon
{
	public override string Name => "Relicanth";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(100, 90, 130, 45, 65, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[5] = new List<Move>() { new Moves.Watergun() },
		[10] = new List<Move>() { new Moves.Ancientpower() },
		[15] = new List<Move>() { new Moves.Yawn() },
		[20] = new List<Move>() { new Moves.Dive() },
		[25] = new List<Move>() { new Moves.Takedown() },
		[30] = new List<Move>() { new Moves.Aquatail() },
		[35] = new List<Move>() { new Moves.Rest() },
		[40] = new List<Move>() { new Moves.Flail() },
		[45] = new List<Move>() { new Moves.Hydropump() },
		[50] = new List<Move>() { new Moves.Doubleedge() },
		[55] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Aquatail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Mudslap(), new Moves.Skullbash(), new Moves.Snore(), new Moves.Zenheadbutt() };
	public override int Weight => 234;
	public override int ExpYield => 170;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}