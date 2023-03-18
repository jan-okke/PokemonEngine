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
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(35, 55, 40, 50, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Playnice(), new Sweetkiss(), new Nuzzle(), new Nastyplot(), new Charm(), new Thundershock(), new Tailwhip(), new Growl(), new Quickattack() },
			[4] = new List<Move>() { new Thunderwave() },
			[8] = new List<Move>() { new Doubleteam() },
			[12] = new List<Move>() { new Electroball() },
			[16] = new List<Move>() { new Feint() },
			[20] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Slam() },
			[32] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Thunderbolt() },
			[40] = new List<Move>() { new Lightscreen() },
			[44] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Brickbreak(), new Chargebeam(), new Charm(), new Dig(), new Doubleteam(), new Drainingkiss(), new Electricterrain(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Nastyplot(), new Payday(), new Playrough(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Reversal(), new Risingvoltage(), new Rocksmash(), new Round(), new Shockwave(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
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