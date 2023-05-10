using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rhyperior : Pokemon
{
	public override string Name => "Rhyperior";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Lightningrod(), new Abilities.Solidrock() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Reckless() };
	public override Stats BaseStats => new Stats(115, 140, 130, 55, 55, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Hammerarm(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Smackdown(), new Moves.Bulldoze() },
		[15] = new List<Move>() { new Moves.Hornattack() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[25] = new List<Move>() { new Moves.Stomp() },
		[30] = new List<Move>() { new Moves.Rockblast() },
		[35] = new List<Move>() { new Moves.Drillrun() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[47] = new List<Move>() { new Moves.Earthquake() },
		[54] = new List<Move>() { new Moves.Stoneedge() },
		[61] = new List<Move>() { new Moves.Megahorn() },
		[68] = new List<Move>() { new Moves.Horndrill() },
		[75] = new List<Move>() { new Moves.Rockwrecker() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Megahorn(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Payday(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Whirlpool() };
	public override int Weight => 2828;
	public override int ExpYield => 268;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}