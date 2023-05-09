using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Eelektrik : Pokemon
{
	public override string Name => "Eelektrik";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(65, 85, 70, 75, 70, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Crunch() },
		[1] = new List<Move>() { new Moves.Crunch(), new Moves.Headbutt(), new Moves.Thunderwave(), new Moves.Spark(), new Moves.Chargebeam() },
		[9] = new List<Move>() { new Moves.Bind() },
		[19] = new List<Move>() { new Moves.Acid() },
		[29] = new List<Move>() { new Moves.Discharge() },
		[44] = new List<Move>() { new Moves.Thunderbolt() },
		[49] = new List<Move>() { new Moves.Acidspray() },
		[54] = new List<Move>() { new Moves.Coil() },
		[59] = new List<Move>() { new Moves.Wildcharge() },
		[64] = new List<Move>() { new Moves.Gastroacid() },
		[69] = new List<Move>() { new Moves.Zapcannon() },
		[74] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Bounce(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 220;
	public override int ExpYield => 142;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}