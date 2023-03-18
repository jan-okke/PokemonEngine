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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Thickfat() };
		public override Stats BaseStats => new Stats(90, 93, 55, 70, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Armthrust() },
			[1] = new List<Move>() { new Moves.Armthrust(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Ember(), new Moves.Odorsleuth() },
			[3] = new List<Move>() { new Moves.Tailwhip() },
			[7] = new List<Move>() { new Moves.Ember() },
			[9] = new List<Move>() { new Moves.Odorsleuth() },
			[13] = new List<Move>() { new Moves.Defensecurl() },
			[15] = new List<Move>() { new Moves.Flamecharge() },
			[20] = new List<Move>() { new Moves.Smog() },
			[23] = new List<Move>() { new Moves.Rollout() },
			[28] = new List<Move>() { new Moves.Takedown() },
			[31] = new List<Move>() { new Moves.Heatcrash() },
			[36] = new List<Move>() { new Moves.Assurance() },
			[39] = new List<Move>() { new Moves.Flamethrower() },
			[44] = new List<Move>() { new Moves.Headsmash() },
			[47] = new List<Move>() { new Moves.Roar() },
			[52] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Overheat(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
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