using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pichu : Pokemon
	{
		public override string Name => "Pichu";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(20, 40, 15, 60, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Tailwhip() },
			[4] = new List<Move>() { new Playnice() },
			[8] = new List<Move>() { new Sweetkiss() },
			[12] = new List<Move>() { new Nuzzle() },
			[16] = new List<Move>() { new Nastyplot() },
			[20] = new List<Move>() { new Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Chargebeam(), new Charm(), new Doubleteam(), new Electricterrain(), new Electroweb(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Nastyplot(), new Playrough(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Reversal(), new Round(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Charge(), new Disarmingvoice(), new Electricterrain(), new Encore(), new Fakeout(), new Flail(), new Present(), new Reversal(), new Thunderpunch(), new Tickle(), new Wish() };
		public override int Weight => 20;
		public override int ExpYield => 41;
		public override int CatchRate => 190;
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