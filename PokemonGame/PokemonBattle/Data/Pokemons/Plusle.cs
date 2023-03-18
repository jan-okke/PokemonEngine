using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Plusle : Pokemon
	{
		public override string Name => "Plusle";
		public override List<Ability> AvailableAbilities => new() {new Plus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(60, 50, 40, 85, 75, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nuzzle(), new Playnice(), new Growl(), new Thunderwave(), new Quickattack() },
			[4] = new List<Move>() { new Helpinghand() },
			[7] = new List<Move>() { new Spark() },
			[10] = new List<Move>() { new Encore() },
			[13] = new List<Move>() { new Skillswap() },
			[16] = new List<Move>() { new Swift() },
			[19] = new List<Move>() { new Electroball() },
			[22] = new List<Move>() { new Copycat() },
			[25] = new List<Move>() { new Charm() },
			[28] = new List<Move>() { new Charge() },
			[31] = new List<Move>() { new Discharge() },
			[34] = new List<Move>() { new Batonpass() },
			[37] = new List<Move>() { new Agility() },
			[40] = new List<Move>() { new Lastresort() },
			[43] = new List<Move>() { new Thunder() },
			[46] = new List<Move>() { new Nastyplot() },
			[49] = new List<Move>() { new Entrainment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Chargebeam(), new Confide(), new Covet(), new Doubleteam(), new Echoedvoice(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Fling(), new Frustration(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lastresort(), new Lightscreen(), new Magnetrise(), new Nastyplot(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Discharge(), new Faketears(), new Sing(), new Sweetkiss(), new Tearfullook(), new Wish() };
		public override int Weight => 42;
		public override int ExpYield => 142;
		public override int CatchRate => 200;
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