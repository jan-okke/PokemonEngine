using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pikachu : Pokemon
	{
		public override string Name => "Pikachu";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightningrod() };
		public override Stats BaseStats => new Stats(35, 55, 40, 50, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Playnice(), new Moves.Sweetkiss(), new Moves.Nuzzle(), new Moves.Nastyplot(), new Moves.Charm(), new Moves.Thundershock(), new Moves.Tailwhip(), new Moves.Growl(), new Moves.Quickattack() },
			[4] = new List<Move>() { new Moves.Thunderwave() },
			[8] = new List<Move>() { new Moves.Doubleteam() },
			[12] = new List<Move>() { new Moves.Electroball() },
			[16] = new List<Move>() { new Moves.Feint() },
			[20] = new List<Move>() { new Moves.Spark() },
			[24] = new List<Move>() { new Moves.Agility() },
			[28] = new List<Move>() { new Moves.Slam() },
			[32] = new List<Move>() { new Moves.Discharge() },
			[36] = new List<Move>() { new Moves.Thunderbolt() },
			[40] = new List<Move>() { new Moves.Lightscreen() },
			[44] = new List<Move>() { new Moves.Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override int Weight => 60;
		public override int ExpYield => 112;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}