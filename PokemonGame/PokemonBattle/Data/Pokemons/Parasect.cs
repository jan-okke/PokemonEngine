using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Parasect : Pokemon
{
	public override string Name => "Parasect";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore(), new Abilities.Dryskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
	public override Stats BaseStats => new Stats(60, 95, 80, 60, 80, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Crosspoison(), new Moves.Scratch(), new Moves.Stunspore(), new Moves.Poisonpowder(), new Moves.Absorb() },
		[6] = new List<Move>() { new Moves.Stunspore(), new Moves.Poisonpowder() },
		[11] = new List<Move>() { new Moves.Absorb() },
		[17] = new List<Move>() { new Moves.Furycutter() },
		[22] = new List<Move>() { new Moves.Spore() },
		[29] = new List<Move>() { new Moves.Slash() },
		[37] = new List<Move>() { new Moves.Growth() },
		[44] = new List<Move>() { new Moves.Gigadrain() },
		[51] = new List<Move>() { new Moves.Aromatherapy() },
		[59] = new List<Move>() { new Moves.Ragepowder() },
		[66] = new List<Move>() { new Moves.Xscissor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Knockoff(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Venoshock(), new Moves.Worryseed(), new Moves.Xscissor() };
	public override int Weight => 295;
	public override int ExpYield => 142;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}