using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Regieleki : Pokemon
{
	public override string Name => "Regieleki";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Transistor() };
	public override Stats BaseStats => new Stats(80, 100, 50, 100, 50, 200);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Rapidspin() },
		[6] = new List<Move>() { new Moves.Electroweb() },
		[12] = new List<Move>() { new Moves.Ancientpower() },
		[18] = new List<Move>() { new Moves.Shockwave() },
		[24] = new List<Move>() { new Moves.Thunderwave() },
		[30] = new List<Move>() { new Moves.Extremespeed() },
		[36] = new List<Move>() { new Moves.Thundercage() },
		[42] = new List<Move>() { new Moves.Thunderbolt() },
		[48] = new List<Move>() { new Moves.Magnetrise() },
		[54] = new List<Move>() { new Moves.Thrash() },
		[60] = new List<Move>() { new Moves.Lockon() },
		[66] = new List<Move>() { new Moves.Zapcannon() },
		[72] = new List<Move>() { new Moves.Hyperbeam() },
		[78] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Assurance(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 1450;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}