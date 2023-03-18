using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bonsly : Pokemon
	{
		public override string Name => "Bonsly";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(50, 80, 95, 10, 45, 10);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Faketears(), new Copycat() },
			[4] = new List<Move>() { new Flail() },
			[8] = new List<Move>() { new Rockthrow() },
			[12] = new List<Move>() { new Block() },
			[16] = new List<Move>() { new Mimic() },
			[20] = new List<Move>() { new Rocktomb() },
			[24] = new List<Move>() { new Tearfullook() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Rockslide() },
			[36] = new List<Move>() { new Lowkick() },
			[40] = new List<Move>() { new Counter() },
			[44] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Calmmind(), new Dig(), new Doubleteam(), new Earthpower(), new Endure(), new Explosion(), new Facade(), new Faketears(), new Foulplay(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Protect(), new Psychup(), new Rest(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Defensecurl(), new Harden(), new Headbutt(), new Rollout(), new Sandtomb(), new Selfdestruct() };
		public override int Weight => 150;
		public override int ExpYield => 58;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}