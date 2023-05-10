using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Galvantula : Pokemon
{
	public override string Name => "Galvantula";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Compoundeyes(), new Abilities.Unnerve() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swarm() };
	public override Stats BaseStats => new Stats(70, 77, 60, 97, 60, 108);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Stickyweb() },
		[1] = new List<Move>() { new Moves.Stickyweb(), new Moves.Absorb(), new Moves.Furycutter(), new Moves.Electroweb(), new Moves.Bugbite() },
		[12] = new List<Move>() { new Moves.Stringshot() },
		[16] = new List<Move>() { new Moves.Thunderwave() },
		[20] = new List<Move>() { new Moves.Electroball() },
		[24] = new List<Move>() { new Moves.Agility() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Slash() },
		[39] = new List<Move>() { new Moves.Discharge() },
		[44] = new List<Move>() { new Moves.Screech() },
		[50] = new List<Move>() { new Moves.Gastroacid() },
		[56] = new List<Move>() { new Moves.Bugbuzz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Xscissor() };
	public override int Weight => 143;
	public override int ExpYield => 165;
	public override int CatchRate => 75;
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