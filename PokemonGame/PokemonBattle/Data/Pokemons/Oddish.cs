using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Oddish : Pokemon
{
	public override string Name => "Oddish";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
	public override Stats BaseStats => new Stats(45, 50, 55, 75, 65, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Growth() },
		[4] = new List<Move>() { new Moves.Acid() },
		[8] = new List<Move>() { new Moves.Sweetscent() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[14] = new List<Move>() { new Moves.Poisonpowder() },
		[16] = new List<Move>() { new Moves.Stunspore() },
		[18] = new List<Move>() { new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Gigadrain() },
		[24] = new List<Move>() { new Moves.Toxic() },
		[28] = new List<Move>() { new Moves.Moonblast() },
		[32] = new List<Move>() { new Moves.Grassyterrain() },
		[36] = new List<Move>() { new Moves.Moonlight() },
		[40] = new List<Move>() { new Moves.Petaldance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Charm(), new Moves.Flail(), new Moves.Ingrain(), new Moves.Leechseed(), new Moves.Naturepower(), new Moves.Razorleaf(), new Moves.Strengthsap(), new Moves.Synthesis(), new Moves.Teeterdance(), new Moves.Tickle() };
	public override int Weight => 54;
	public override int ExpYield => 64;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}