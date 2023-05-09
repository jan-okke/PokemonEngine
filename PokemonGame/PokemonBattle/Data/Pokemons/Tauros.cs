using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tauros : Pokemon
{
	public override string Name => "Tauros";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Angerpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(75, 100, 95, 40, 70, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Workup() },
		[10] = new List<Move>() { new Moves.Payback() },
		[15] = new List<Move>() { new Moves.Assurance() },
		[20] = new List<Move>() { new Moves.Hornattack() },
		[25] = new List<Move>() { new Moves.Scaryface() },
		[30] = new List<Move>() { new Moves.Zenheadbutt() },
		[35] = new List<Move>() { new Moves.Takedown() },
		[40] = new List<Move>() { new Moves.Rest() },
		[45] = new List<Move>() { new Moves.Swagger() },
		[50] = new List<Move>() { new Moves.Thrash() },
		[55] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Megahorn(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 884;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}