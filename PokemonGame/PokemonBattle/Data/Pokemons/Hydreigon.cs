using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hydreigon : Pokemon
	{
		public override string Name => "Hydreigon";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(92, 105, 90, 125, 90, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Doublehit(), new Triattack(), new Focusenergy(), new Dragonbreath(), new Bite() },
			[12] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Workup() },
			[28] = new List<Move>() { new Slam() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Scaryface() },
			[40] = new List<Move>() { new Dragonpulse() },
			[44] = new List<Move>() { new Bodyslam() },
			[48] = new List<Move>() { new Hypervoice() },
			[54] = new List<Move>() { new Dragonrush() },
			[60] = new List<Move>() { new Nastyplot() },
			[68] = new List<Move>() { new Outrage() },
			[76] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flashcannon(), new Fly(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icefang(), new Irontail(), new Nastyplot(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scaleshot(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Steelwing(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Taunt(), new Thief(), new Throatchop(), new Thunderfang(), new Thunderwave(), new Triattack(), new Uproar(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 1600;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}