using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Electrode : Pokemon
{
	public override string Name => "Electrode";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Soundproof(), new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aftermath() };
	public override Stats BaseStats => new Stats(60, 50, 70, 80, 80, 150);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Magneticflux(), new Moves.Charge(), new Moves.Tackle(), new Moves.Eerieimpulse() },
		[4] = new List<Move>() { new Moves.Thundershock() },
		[6] = new List<Move>() { new Moves.Eerieimpulse() },
		[9] = new List<Move>() { new Moves.Spark() },
		[11] = new List<Move>() { new Moves.Rollout() },
		[13] = new List<Move>() { new Moves.Screech() },
		[16] = new List<Move>() { new Moves.Chargebeam() },
		[20] = new List<Move>() { new Moves.Swift() },
		[22] = new List<Move>() { new Moves.Electroball() },
		[26] = new List<Move>() { new Moves.Selfdestruct() },
		[29] = new List<Move>() { new Moves.Lightscreen() },
		[36] = new List<Move>() { new Moves.Magnetrise() },
		[41] = new List<Move>() { new Moves.Discharge() },
		[47] = new List<Move>() { new Moves.Explosion() },
		[54] = new List<Move>() { new Moves.Gyroball() },
		[58] = new List<Move>() { new Moves.Mirrorcoat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 666;
	public override int ExpYield => 172;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}