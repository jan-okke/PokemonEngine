using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dragonite : Pokemon
	{
		public override string Name => "Dragonite";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Multiscale() };
		public override Stats BaseStats => new Stats(91, 134, 95, 100, 100, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hurricane() },
			[1] = new List<Move>() { new Hurricane(), new Wingattack(), new Roost(), new Extremespeed(), new Firepunch(), new Thunderpunch(), new Wrap(), new Leer(), new Twister(), new Thunderwave() },
			[15] = new List<Move>() { new Dragontail() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Slam() },
			[33] = new List<Move>() { new Aquatail() },
			[39] = new List<Move>() { new Dragonrush() },
			[41] = new List<Move>() { new Outrage() },
			[46] = new List<Move>() { new Safeguard() },
			[53] = new List<Move>() { new Raindance() },
			[62] = new List<Move>() { new Dragondance() },
			[80] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Cut(), new Defog(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Fling(), new Fly(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Hail(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Ironhead(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 2100;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}