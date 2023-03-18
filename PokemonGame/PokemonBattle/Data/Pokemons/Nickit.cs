using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nickit : Pokemon
	{
		public override string Name => "Nickit";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stakeout() };
		public override Stats BaseStats => new Stats(40, 28, 28, 47, 52, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Tailwhip() },
			[4] = new List<Move>() { new Beatup() },
			[8] = new List<Move>() { new Honeclaws() },
			[12] = new List<Move>() { new Snarl() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Nastyplot() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Nightslash() },
			[32] = new List<Move>() { new Tailslap() },
			[36] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Batonpass(), new Beatup(), new Dig(), new Endure(), new Facade(), new Faketears(), new Foulplay(), new Hiddenpower(), new Lashout(), new Mudshot(), new Nastyplot(), new Playrough(), new Protect(), new Rest(), new Round(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Swift(), new Tailslap(), new Taunt(), new Thief() };
		public override List<Move> EggMoves => new List<Move>() { new Howl(), new Knockoff(), new Quickguard(), new Torment() };
		public override int Weight => 89;
		public override int ExpYield => 49;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}