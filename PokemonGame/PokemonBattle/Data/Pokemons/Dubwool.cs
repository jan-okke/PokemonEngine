using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dubwool : Pokemon
	{
		public override string Name => "Dubwool";
		public override List<Ability> AvailableAbilities => new() {new Fluffy(), new Steadfast() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bulletproof() };
		public override Stats BaseStats => new Stats(72, 80, 100, 60, 90, 88);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Defensecurl(), new Copycat() },
			[12] = new List<Move>() { new Guardsplit() },
			[16] = new List<Move>() { new Doublekick() },
			[21] = new List<Move>() { new Headbutt() },
			[27] = new List<Move>() { new Takedown() },
			[32] = new List<Move>() { new Guardswap() },
			[38] = new List<Move>() { new Reversal() },
			[44] = new List<Move>() { new Cottonguard() },
			[50] = new List<Move>() { new Doubleedge() },
			[56] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Batonpass(), new Bodypress(), new Bodyslam(), new Bounce(), new Electroball(), new Endure(), new Facade(), new Gigaimpact(), new Grassyglide(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Megakick(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Reversal(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Swordsdance(), new Thunderwave(), new Wildcharge(), new Zenheadbutt() };
		public override int Weight => 430;
		public override int ExpYield => 172;
		public override int CatchRate => 127;
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