using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Joltik : Pokemon
{
	public override string Name => "Joltik";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Compoundeyes(), new Abilities.Unnerve() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swarm() };
	public override Stats BaseStats => new Stats(50, 47, 50, 57, 50, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Furycutter() },
		[4] = new List<Move>() { new Moves.Electroweb() },
		[8] = new List<Move>() { new Moves.Bugbite() },
		[12] = new List<Move>() { new Moves.Stringshot() },
		[16] = new List<Move>() { new Moves.Thunderwave() },
		[20] = new List<Move>() { new Moves.Electroball() },
		[24] = new List<Move>() { new Moves.Agility() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Slash() },
		[37] = new List<Move>() { new Moves.Discharge() },
		[40] = new List<Move>() { new Moves.Screech() },
		[44] = new List<Move>() { new Moves.Gastroacid() },
		[48] = new List<Move>() { new Moves.Bugbuzz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleteam(), new Moves.Infestation(), new Moves.Lunge(), new Moves.Poisonsting(), new Moves.Strugglebug() };
	public override int Weight => 6;
	public override int ExpYield => 64;
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