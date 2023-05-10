using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Diggersby : Pokemon
{
	public override string Name => "Diggersby";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Cheekpouch() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hugepower() };
	public override Stats BaseStats => new Stats(85, 56, 77, 50, 77, 78);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Leer(), new Moves.Tackle(), new Moves.Laserfocus() },
		[9] = new List<Move>() { new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Mudshot() },
		[15] = new List<Move>() { new Moves.Flail() },
		[18] = new List<Move>() { new Moves.Doublekick() },
		[23] = new List<Move>() { new Moves.Bulldoze() },
		[28] = new List<Move>() { new Moves.Dig() },
		[33] = new List<Move>() { new Moves.Bounce() },
		[38] = new List<Move>() { new Moves.Takedown() },
		[43] = new List<Move>() { new Moves.Swordsdance() },
		[48] = new List<Move>() { new Moves.Earthquake() },
		[53] = new List<Move>() { new Moves.Superfang() },
		[58] = new List<Move>() { new Moves.Hammerarm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Workup() };
	public override int Weight => 424;
	public override int ExpYield => 148;
	public override int CatchRate => 127;
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