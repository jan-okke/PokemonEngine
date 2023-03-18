using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Typhlosion : Pokemon
	{
		public override string Name => "Typhlosion";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(78, 84, 78, 100, 109, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Eruption(), new Doubleedge(), new Gyroball(), new Tackle(), new Leer(), new Smokescreen(), new Ember() },
			[6] = new List<Move>() { new Smokescreen() },
			[10] = new List<Move>() { new Ember() },
			[13] = new List<Move>() { new Quickattack() },
			[20] = new List<Move>() { new Flamewheel() },
			[24] = new List<Move>() { new Defensecurl() },
			[31] = new List<Move>() { new Swift() },
			[35] = new List<Move>() { new Flamecharge() },
			[43] = new List<Move>() { new Lavaplume() },
			[48] = new List<Move>() { new Flamethrower() },
			[56] = new List<Move>() { new Inferno() },
			[61] = new List<Move>() { new Rollout() },
			[69] = new List<Move>() { new Doubleedge() },
			[74] = new List<Move>() { new Burnup() },
			[82] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blastburn(), new Brickbreak(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Lowkick(), new Naturepower(), new Overheat(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Throatchop(), new Thunderpunch(), new Wildcharge(), new Willowisp(), new Workup() };
		public override int Weight => 795;
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