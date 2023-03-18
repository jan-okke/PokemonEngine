using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bewear : Pokemon
	{
		public override string Name => "Bewear";
		public override List<Ability> AvailableAbilities => new() {new Fluffy(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(120, 125, 80, 60, 55, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bind() },
			[1] = new List<Move>() { new Bind(), new Tackle(), new Leer(), new Babydolleyes(), new Payback() },
			[12] = new List<Move>() { new Brutalswing() },
			[16] = new List<Move>() { new Endure() },
			[20] = new List<Move>() { new Strength() },
			[24] = new List<Move>() { new Takedown() },
			[30] = new List<Move>() { new Flail() },
			[36] = new List<Move>() { new Hammerarm() },
			[42] = new List<Move>() { new Thrash() },
			[48] = new List<Move>() { new Painsplit() },
			[54] = new List<Move>() { new Doubleedge() },
			[60] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Charm(), new Closecombat(), new Coaching(), new Darkestlariat(), new Dragonclaw(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icepunch(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override int Weight => 1350;
		public override int ExpYield => 175;
		public override int CatchRate => 70;
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