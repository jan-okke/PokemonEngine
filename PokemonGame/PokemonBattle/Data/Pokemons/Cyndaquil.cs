using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cyndaquil : Pokemon
	{
		public override string Name => "Cyndaquil";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flashfire() };
		public override Stats BaseStats => new Stats(39, 52, 43, 60, 50, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
			[6] = new List<Move>() { new Moves.Smokescreen() },
			[10] = new List<Move>() { new Moves.Ember() },
			[13] = new List<Move>() { new Moves.Quickattack() },
			[19] = new List<Move>() { new Moves.Flamewheel() },
			[22] = new List<Move>() { new Moves.Defensecurl() },
			[28] = new List<Move>() { new Moves.Flamecharge() },
			[31] = new List<Move>() { new Moves.Swift() },
			[37] = new List<Move>() { new Moves.Lavaplume() },
			[40] = new List<Move>() { new Moves.Flamethrower() },
			[46] = new List<Move>() { new Moves.Inferno() },
			[49] = new List<Move>() { new Moves.Rollout() },
			[55] = new List<Move>() { new Moves.Doubleedge() },
			[58] = new List<Move>() { new Moves.Burnup() },
			[64] = new List<Move>() { new Moves.Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Covet(), new Moves.Crushclaw(), new Moves.Doubleedge(), new Moves.Doublekick(), new Moves.Extrasensory(), new Moves.Flareblitz(), new Moves.Furyswipes(), new Moves.Howl(), new Moves.Naturepower(), new Moves.Quickattack(), new Moves.Reversal(), new Moves.Thrash() };
		public override int Weight => 79;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}