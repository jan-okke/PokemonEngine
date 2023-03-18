using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Emboar : Pokemon
	{
		public override string Name => "Emboar";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(110, 123, 65, 100, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Armthrust(), new Hammerarm(), new Tackle(), new Tailwhip(), new Ember(), new Odorsleuth() },
			[3] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Odorsleuth() },
			[13] = new List<Move>() { new Defensecurl() },
			[15] = new List<Move>() { new Flamecharge() },
			[20] = new List<Move>() { new Smog() },
			[23] = new List<Move>() { new Rollout() },
			[28] = new List<Move>() { new Takedown() },
			[31] = new List<Move>() { new Heatcrash() },
			[38] = new List<Move>() { new Assurance() },
			[43] = new List<Move>() { new Flamethrower() },
			[50] = new List<Move>() { new Headsmash() },
			[55] = new List<Move>() { new Roar() },
			[62] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blastburn(), new Block(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Doubleteam(), new Earthquake(), new Echoedvoice(), new Endeavor(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Lowkick(), new Lowsweep(), new Overheat(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Smackdown(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Taunt(), new Thunderpunch(), new Toxic(), new Wildcharge(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override int Weight => 1500;
		public override int ExpYield => 264;
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