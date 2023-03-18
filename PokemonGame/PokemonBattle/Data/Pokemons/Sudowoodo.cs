using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sudowoodo : Pokemon
	{
		public override string Name => "Sudowoodo";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(70, 100, 115, 30, 65, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slam() },
			[1] = new List<Move>() { new Slam(), new Stoneedge(), new Hammerarm(), new Woodhammer(), new Faketears(), new Copycat(), new Flail(), new Rockthrow() },
			[12] = new List<Move>() { new Block() },
			[16] = new List<Move>() { new Mimic() },
			[20] = new List<Move>() { new Rocktomb() },
			[24] = new List<Move>() { new Tearfullook() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Rockslide() },
			[36] = new List<Move>() { new Lowkick() },
			[40] = new List<Move>() { new Counter() },
			[44] = new List<Move>() { new Doubleedge() },
			[48] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Calmmind(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focuspunch(), new Foulplay(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Lowkick(), new Megakick(), new Megapunch(), new Meteorbeam(), new Protect(), new Psychup(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Defensecurl(), new Harden(), new Headbutt(), new Rollout(), new Sandtomb(), new Selfdestruct() };
		public override int Weight => 380;
		public override int ExpYield => 144;
		public override int CatchRate => 65;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}