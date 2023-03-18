using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tepig : Pokemon
	{
		public override string Name => "Tepig";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Thickfat() };
		public override Stats BaseStats => new Stats(65, 63, 45, 45, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[3] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Odorsleuth() },
			[13] = new List<Move>() { new Defensecurl() },
			[15] = new List<Move>() { new Flamecharge() },
			[19] = new List<Move>() { new Smog() },
			[21] = new List<Move>() { new Rollout() },
			[25] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Heatcrash() },
			[31] = new List<Move>() { new Assurance() },
			[33] = new List<Move>() { new Flamethrower() },
			[37] = new List<Move>() { new Headsmash() },
			[39] = new List<Move>() { new Roar() },
			[43] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Covet(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Facade(), new Fireblast(), new Firepledge(), new Flamecharge(), new Flamethrower(), new Frustration(), new Grassknot(), new Gyroball(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Overheat(), new Protect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Taunt(), new Toxic(), new Wildcharge(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Burnup(), new Covet(), new Curse(), new Endeavor(), new Heavyslam(), new Magnitude(), new Sleeptalk(), new Suckerpunch(), new Superpower(), new Thrash(), new Yawn() };
		public override int Weight => 99;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}