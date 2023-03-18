using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lairon : Pokemon
	{
		public override string Name => "Lairon";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(60, 90, 140, 40, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden(), new Metalclaw(), new Rocktomb() },
			[12] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Rockslide() },
			[28] = new List<Move>() { new Ironhead() },
			[35] = new List<Move>() { new Metalsound() },
			[40] = new List<Move>() { new Takedown() },
			[46] = new List<Move>() { new Autotomize() },
			[52] = new List<Move>() { new Irontail() },
			[58] = new List<Move>() { new Irondefense() },
			[64] = new List<Move>() { new Heavyslam() },
			[70] = new List<Move>() { new Doubleedge() },
			[76] = new List<Move>() { new Metalburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Heavyslam(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Roar(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Screech(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Uproar(), new Waterpulse() };
		public override int Weight => 1200;
		public override int ExpYield => 151;
		public override int CatchRate => 90;
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