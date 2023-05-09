using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gloom : Pokemon
{
	public override string Name => "Gloom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stench() };
	public override Stats BaseStats => new Stats(60, 65, 70, 85, 75, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Growth(), new Moves.Acid(), new Moves.Sweetscent() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[14] = new List<Move>() { new Moves.Poisonpowder() },
		[16] = new List<Move>() { new Moves.Stunspore() },
		[18] = new List<Move>() { new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Gigadrain() },
		[26] = new List<Move>() { new Moves.Toxic() },
		[32] = new List<Move>() { new Moves.Moonblast() },
		[38] = new List<Move>() { new Moves.Grassyterrain() },
		[44] = new List<Move>() { new Moves.Moonlight() },
		[50] = new List<Move>() { new Moves.Petaldance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Venoshock() };
	public override int Weight => 86;
	public override int ExpYield => 138;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}