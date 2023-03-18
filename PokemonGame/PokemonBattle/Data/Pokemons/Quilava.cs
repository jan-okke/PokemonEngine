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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flashfire() };
		public override Stats BaseStats => new Stats(58, 64, 58, 80, 65, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer(), new Moves.Smokescreen() },
			[6] = new List<Move>() { new Moves.Smokescreen() },
			[10] = new List<Move>() { new Moves.Ember() },
			[13] = new List<Move>() { new Moves.Quickattack() },
			[20] = new List<Move>() { new Moves.Flamewheel() },
			[24] = new List<Move>() { new Moves.Defensecurl() },
			[31] = new List<Move>() { new Moves.Swift() },
			[35] = new List<Move>() { new Moves.Flamecharge() },
			[42] = new List<Move>() { new Moves.Lavaplume() },
			[46] = new List<Move>() { new Moves.Flamethrower() },
			[53] = new List<Move>() { new Moves.Inferno() },
			[57] = new List<Move>() { new Moves.Rollout() },
			[64] = new List<Move>() { new Moves.Doubleedge() },
			[68] = new List<Move>() { new Moves.Burnup() },
			[75] = new List<Move>() { new Moves.Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup() };
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