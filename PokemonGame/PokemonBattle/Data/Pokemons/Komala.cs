using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Komala : Pokemon
	{
		public override string Name => "Komala";
		public override List<Ability> AvailableAbilities => new() {new Comatose() };
		public override Stats BaseStats => new Stats(65, 115, 65, 65, 75, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Defensecurl(), new Rollout() },
			[6] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[11] = new List<Move>() { new Rapidspin() },
			[16] = new List<Move>() { new Yawn() },
			[21] = new List<Move>() { new Slam() },
			[26] = new List<Move>() { new Flail() },
			[31] = new List<Move>() { new Suckerpunch() },
			[36] = new List<Move>() { new Psychup() },
			[41] = new List<Move>() { new Woodhammer() },
			[46] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Calmmind(), new Confide(), new Doubleteam(), new Earthquake(), new Endeavor(), new Facade(), new Frustration(), new Hiddenpower(), new Ironhead(), new Knockoff(), new Lastresort(), new Lowsweep(), new Payback(), new Protect(), new Psychup(), new Quash(), new Return(), new Rockslide(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Toxic(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Playrough(), new Sing(), new Wish() };
		public override int Weight => 199;
		public override int ExpYield => 168;
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