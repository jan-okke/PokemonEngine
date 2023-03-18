using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pignite : Pokemon
	{
		public override string Name => "Pignite";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Thickfat() };
		public override Stats BaseStats => new Stats(90, 93, 55, 55, 70, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Armthrust() },
			[1] = new List<Move>() { new Armthrust(), new Tackle(), new Tailwhip(), new Ember(), new Odorsleuth() },
			[3] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Odorsleuth() },
			[13] = new List<Move>() { new Defensecurl() },
			[15] = new List<Move>() { new Flamecharge() },
			[20] = new List<Move>() { new Smog() },
			[23] = new List<Move>() { new Rollout() },
			[28] = new List<Move>() { new Takedown() },
			[31] = new List<Move>() { new Heatcrash() },
			[36] = new List<Move>() { new Assurance() },
			[39] = new List<Move>() { new Flamethrower() },
			[44] = new List<Move>() { new Headsmash() },
			[47] = new List<Move>() { new Roar() },
			[52] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulldoze(), new Confide(), new Covet(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Grassknot(), new Gyroball(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lowkick(), new Lowsweep(), new Overheat(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Taunt(), new Thunderpunch(), new Toxic(), new Wildcharge(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override int Weight => 555;
		public override int ExpYield => 146;
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