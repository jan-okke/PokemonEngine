using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Quilava : Pokemon
	{
		public override string Name => "Quilava";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(58, 64, 58, 80, 80, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer(), new Smokescreen() },
			[6] = new List<Move>() { new Smokescreen() },
			[10] = new List<Move>() { new Ember() },
			[13] = new List<Move>() { new Quickattack() },
			[20] = new List<Move>() { new Flamewheel() },
			[24] = new List<Move>() { new Defensecurl() },
			[31] = new List<Move>() { new Swift() },
			[35] = new List<Move>() { new Flamecharge() },
			[42] = new List<Move>() { new Lavaplume() },
			[46] = new List<Move>() { new Flamethrower() },
			[53] = new List<Move>() { new Inferno() },
			[57] = new List<Move>() { new Rollout() },
			[64] = new List<Move>() { new Doubleedge() },
			[68] = new List<Move>() { new Burnup() },
			[75] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brickbreak(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Flamecharge(), new Flamethrower(), new Focuspunch(), new Frustration(), new Heatwave(), new Hiddenpower(), new Naturepower(), new Overheat(), new Protect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Wildcharge(), new Willowisp(), new Workup() };
		public override int Weight => 190;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}