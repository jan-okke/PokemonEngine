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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Roughskin(), new Abilities.Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
		public override Stats BaseStats => new Stats(77, 120, 90, 60, 90, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Bite() },
			[10] = new List<Move>() { new Moves.Dragontail() },
			[15] = new List<Move>() { new Moves.Metalclaw() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Slash() },
			[30] = new List<Move>() { new Moves.Dragonclaw() },
			[35] = new List<Move>() { new Moves.Honeclaws() },
			[40] = new List<Move>() { new Moves.Crunch() },
			[45] = new List<Move>() { new Moves.Ironhead() },
			[50] = new List<Move>() { new Moves.Outrage() },
			[55] = new List<Move>() { new Moves.Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Taunt(), new Moves.Thunderfang(), new Moves.Thunderpunch() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Glare(), new Moves.Nightslash(), new Moves.Poisontail(), new Moves.Suckerpunch() };
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