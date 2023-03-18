using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stufful : Pokemon
	{
		public override string Name => "Stufful";
		public override List<Ability> AvailableAbilities => new() {new Fluffy(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cutecharm() };
		public override Stats BaseStats => new Stats(70, 75, 50, 50, 45, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Babydolleyes() },
			[8] = new List<Move>() { new Payback() },
			[12] = new List<Move>() { new Brutalswing() },
			[16] = new List<Move>() { new Endure() },
			[20] = new List<Move>() { new Strength() },
			[24] = new List<Move>() { new Takedown() },
			[28] = new List<Move>() { new Flail() },
			[32] = new List<Move>() { new Hammerarm() },
			[36] = new List<Move>() { new Thrash() },
			[40] = new List<Move>() { new Painsplit() },
			[44] = new List<Move>() { new Doubleedge() },
			[48] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Charm(), new Coaching(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Hiddenpower(), new Icepunch(), new Ironhead(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Defensecurl(), new Forcepalm(), new Rollout(), new Stomp() };
		public override int Weight => 68;
		public override int ExpYield => 68;
		public override int CatchRate => 140;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}