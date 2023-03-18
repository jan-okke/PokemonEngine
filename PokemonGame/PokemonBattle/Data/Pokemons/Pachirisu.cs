using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pachirisu : Pokemon
	{
		public override string Name => "Pachirisu";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Voltabsorb() };
		public override Stats BaseStats => new Stats(60, 45, 70, 45, 90, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Babydolleyes() },
			[5] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Charm() },
			[13] = new List<Move>() { new Spark() },
			[17] = new List<Move>() { new Endure() },
			[19] = new List<Move>() { new Nuzzle() },
			[21] = new List<Move>() { new Swift() },
			[25] = new List<Move>() { new Electroball() },
			[29] = new List<Move>() { new Sweetkiss() },
			[33] = new List<Move>() { new Thunderwave() },
			[37] = new List<Move>() { new Superfang() },
			[41] = new List<Move>() { new Discharge() },
			[45] = new List<Move>() { new Lastresort() },
			[49] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Echoedvoice(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Fling(), new Frustration(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Seedbomb(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Superfang(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Uturn(), new Voltswitch() };
		public override List<Move> EggMoves => new List<Move>() { new Babydolleyes(), new Bite(), new Charge(), new Covet(), new Defensecurl(), new Faketears(), new Flail(), new Flatter(), new Followme(), new Rollout(), new Tailwhip() };
		public override int Weight => 39;
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