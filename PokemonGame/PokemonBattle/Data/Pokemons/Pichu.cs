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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightningrod() };
		public override Stats BaseStats => new Stats(20, 40, 15, 35, 35, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Tailwhip() },
			[4] = new List<Move>() { new Moves.Playnice() },
			[8] = new List<Move>() { new Moves.Sweetkiss() },
			[12] = new List<Move>() { new Moves.Nuzzle() },
			[16] = new List<Move>() { new Moves.Nastyplot() },
			[20] = new List<Move>() { new Moves.Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Electricterrain(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Charge(), new Moves.Disarmingvoice(), new Moves.Electricterrain(), new Moves.Encore(), new Moves.Fakeout(), new Moves.Flail(), new Moves.Present(), new Moves.Reversal(), new Moves.Thunderpunch(), new Moves.Tickle(), new Moves.Wish() };
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