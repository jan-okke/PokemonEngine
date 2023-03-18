using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Diggersby : Pokemon
	{
		public override string Name => "Diggersby";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hugepower() };
		public override Stats BaseStats => new Stats(85, 56, 77, 78, 50, 77);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Leer(), new Tackle(), new Laserfocus() },
			[9] = new List<Move>() { new Quickattack() },
			[12] = new List<Move>() { new Mudshot() },
			[15] = new List<Move>() { new Flail() },
			[18] = new List<Move>() { new Doublekick() },
			[23] = new List<Move>() { new Bulldoze() },
			[28] = new List<Move>() { new Dig() },
			[33] = new List<Move>() { new Bounce() },
			[38] = new List<Move>() { new Takedown() },
			[43] = new List<Move>() { new Swordsdance() },
			[48] = new List<Move>() { new Earthquake() },
			[53] = new List<Move>() { new Superfang() },
			[58] = new List<Move>() { new Hammerarm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Bounce(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icepunch(), new Ironhead(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Spikes(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Swordsdance(), new Thief(), new Thunderpunch(), new Uproar(), new Uturn(), new Wildcharge(), new Workup() };
		public override int Weight => 424;
		public override int ExpYield => 148;
		public override int CatchRate => 127;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}