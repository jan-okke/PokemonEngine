using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Charizard : Pokemon
	{
		public override string Name => "Charizard";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Solarpower() };
		public override Stats BaseStats => new Stats(78, 84, 78, 100, 109, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Airslash() },
			[1] = new List<Move>() { new Airslash(), new Dragonclaw(), new Heatwave(), new Scratch(), new Growl(), new Ember(), new Smokescreen() },
			[12] = new List<Move>() { new Dragonbreath() },
			[19] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Flamethrower() },
			[39] = new List<Move>() { new Scaryface() },
			[46] = new List<Move>() { new Firespin() },
			[54] = new List<Move>() { new Inferno() },
			[62] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Airslash(), new Attract(), new Beatup(), new Blastburn(), new Blazekick(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firefang(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Fly(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Irontail(), new Megakick(), new Megapunch(), new Mysticalfire(), new Outrage(), new Overheat(), new Protect(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Weatherball(), new Willowisp(), new Workup() };
		public override int Weight => 905;
		public override int ExpYield => 267;
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