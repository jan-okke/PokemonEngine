using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wooloo : Pokemon
	{
		public override string Name => "Wooloo";
		public override List<Ability> AvailableAbilities => new() {new Fluffy(), new Runaway() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bulletproof() };
		public override Stats BaseStats => new Stats(42, 40, 55, 48, 40, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Copycat() },
			[12] = new List<Move>() { new Guardsplit() },
			[16] = new List<Move>() { new Doublekick() },
			[21] = new List<Move>() { new Headbutt() },
			[25] = new List<Move>() { new Takedown() },
			[28] = new List<Move>() { new Guardswap() },
			[32] = new List<Move>() { new Reversal() },
			[36] = new List<Move>() { new Cottonguard() },
			[40] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Electroball(), new Endure(), new Facade(), new Grassyglide(), new Guardswap(), new Hiddenpower(), new Payback(), new Protect(), new Rest(), new Reversal(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Thunderwave(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Stomp(), new Swagger() };
		public override int Weight => 60;
		public override int ExpYield => 122;
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