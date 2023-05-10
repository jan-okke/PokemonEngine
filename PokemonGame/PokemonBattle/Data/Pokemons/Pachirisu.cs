using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pachirisu : Pokemon
{
	public override string Name => "Pachirisu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Pickup() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Voltabsorb() };
	public override Stats BaseStats => new Stats(60, 45, 70, 45, 90, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Babydolleyes() },
		[5] = new List<Move>() { new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Charm() },
		[13] = new List<Move>() { new Moves.Spark() },
		[17] = new List<Move>() { new Moves.Endure() },
		[19] = new List<Move>() { new Moves.Nuzzle() },
		[21] = new List<Move>() { new Moves.Swift() },
		[25] = new List<Move>() { new Moves.Electroball() },
		[29] = new List<Move>() { new Moves.Sweetkiss() },
		[33] = new List<Move>() { new Moves.Thunderwave() },
		[37] = new List<Move>() { new Moves.Superfang() },
		[41] = new List<Move>() { new Moves.Discharge() },
		[45] = new List<Move>() { new Moves.Lastresort() },
		[49] = new List<Move>() { new Moves.Thunder() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Voltswitch() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Babydolleyes(), new Moves.Bite(), new Moves.Charge(), new Moves.Covet(), new Moves.Defensecurl(), new Moves.Faketears(), new Moves.Flail(), new Moves.Flatter(), new Moves.Followme(), new Moves.Rollout(), new Moves.Tailwhip() };
	public override int Weight => 39;
	public override int ExpYield => 142;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}