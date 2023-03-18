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
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(39, 52, 43, 60, 50, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[6] = new List<Move>() { new Smokescreen() },
			[10] = new List<Move>() { new Ember() },
			[13] = new List<Move>() { new Quickattack() },
			[19] = new List<Move>() { new Flamewheel() },
			[22] = new List<Move>() { new Defensecurl() },
			[28] = new List<Move>() { new Flamecharge() },
			[31] = new List<Move>() { new Swift() },
			[37] = new List<Move>() { new Lavaplume() },
			[40] = new List<Move>() { new Flamethrower() },
			[46] = new List<Move>() { new Inferno() },
			[49] = new List<Move>() { new Rollout() },
			[55] = new List<Move>() { new Doubleedge() },
			[58] = new List<Move>() { new Burnup() },
			[64] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Flamecharge(), new Flamethrower(), new Frustration(), new Heatwave(), new Hiddenpower(), new Naturepower(), new Overheat(), new Protect(), new Rest(), new Return(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Wildcharge(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Covet(), new Crushclaw(), new Doubleedge(), new Doublekick(), new Extrasensory(), new Flareblitz(), new Furyswipes(), new Howl(), new Naturepower(), new Quickattack(), new Reversal(), new Thrash() };
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