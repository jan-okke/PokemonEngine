using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Druddigon : Pokemon
	{
		public override string Name => "Druddigon";
		public override List<Ability> AvailableAbilities => new() {new Roughskin(), new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(77, 120, 90, 60, 90, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[5] = new List<Move>() { new Bite() },
			[10] = new List<Move>() { new Dragontail() },
			[15] = new List<Move>() { new Metalclaw() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Dragonclaw() },
			[35] = new List<Move>() { new Honeclaws() },
			[40] = new List<Move>() { new Crunch() },
			[45] = new List<Move>() { new Ironhead() },
			[50] = new List<Move>() { new Outrage() },
			[55] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dig(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Firepunch(), new Flamethrower(), new Flashcannon(), new Fling(), new Focusblast(), new Gigaimpact(), new Gunkshot(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Lashout(), new Megapunch(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Taunt(), new Thunderfang(), new Thunderpunch() };
		public override List<Move> EggMoves => new List<Move>() { new Glare(), new Nightslash(), new Poisontail(), new Suckerpunch() };
		public override int Weight => 1390;
		public override int ExpYield => 170;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}