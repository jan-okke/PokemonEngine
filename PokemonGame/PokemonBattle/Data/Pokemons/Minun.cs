using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Minun : Pokemon
	{
		public override string Name => "Minun";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Voltabsorb() };
		public override Stats BaseStats => new Stats(60, 40, 50, 75, 85, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Nuzzle(), new Moves.Playnice(), new Moves.Growl(), new Moves.Thunderwave(), new Moves.Quickattack() },
			[4] = new List<Move>() { new Moves.Helpinghand() },
			[7] = new List<Move>() { new Moves.Spark() },
			[10] = new List<Move>() { new Moves.Encore() },
			[13] = new List<Move>() { new Moves.Switcheroo() },
			[16] = new List<Move>() { new Moves.Swift() },
			[19] = new List<Move>() { new Moves.Electroball() },
			[22] = new List<Move>() { new Moves.Copycat() },
			[25] = new List<Move>() { new Moves.Faketears() },
			[28] = new List<Move>() { new Moves.Charge() },
			[31] = new List<Move>() { new Moves.Discharge() },
			[34] = new List<Move>() { new Moves.Batonpass() },
			[37] = new List<Move>() { new Moves.Agility() },
			[40] = new List<Move>() { new Moves.Lastresort() },
			[43] = new List<Move>() { new Moves.Thunder() },
			[46] = new List<Move>() { new Moves.Nastyplot() },
			[49] = new List<Move>() { new Moves.Entrainment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Charm(), new Moves.Discharge(), new Moves.Faketears(), new Moves.Sing(), new Moves.Sweetkiss(), new Moves.Tearfullook(), new Moves.Wish() };
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