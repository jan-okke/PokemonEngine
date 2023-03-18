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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Multiscale() };
		public override Stats BaseStats => new Stats(91, 134, 95, 100, 100, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Hurricane() },
			[1] = new List<Move>() { new Moves.Hurricane(), new Moves.Wingattack(), new Moves.Roost(), new Moves.Extremespeed(), new Moves.Firepunch(), new Moves.Thunderpunch(), new Moves.Wrap(), new Moves.Leer(), new Moves.Twister(), new Moves.Thunderwave() },
			[15] = new List<Move>() { new Moves.Dragontail() },
			[20] = new List<Move>() { new Moves.Agility() },
			[25] = new List<Move>() { new Moves.Slam() },
			[33] = new List<Move>() { new Moves.Aquatail() },
			[39] = new List<Move>() { new Moves.Dragonrush() },
			[41] = new List<Move>() { new Moves.Outrage() },
			[46] = new List<Move>() { new Moves.Safeguard() },
			[53] = new List<Move>() { new Moves.Raindance() },
			[62] = new List<Move>() { new Moves.Dragondance() },
			[80] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
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