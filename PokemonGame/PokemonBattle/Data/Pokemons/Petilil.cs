using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Petilil : Pokemon
{
	public override string Name => "Petilil";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Owntempo() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
	public override Stats BaseStats => new Stats(45, 35, 50, 70, 50, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Growth() },
		[3] = new List<Move>() { new Moves.Helpinghand() },
		[6] = new List<Move>() { new Moves.Stunspore() },
		[9] = new List<Move>() { new Moves.Megadrain() },
		[12] = new List<Move>() { new Moves.Aromatherapy() },
		[15] = new List<Move>() { new Moves.Magicalleaf() },
		[18] = new List<Move>() { new Moves.Sleeppowder() },
		[21] = new List<Move>() { new Moves.Gigadrain() },
		[24] = new List<Move>() { new Moves.Leechseed() },
		[27] = new List<Move>() { new Moves.Afteryou() },
		[30] = new List<Move>() { new Moves.Energyball() },
		[33] = new List<Move>() { new Moves.Synthesis() },
		[36] = new List<Move>() { new Moves.Sunnyday() },
		[39] = new List<Move>() { new Moves.Entrainment() },
		[42] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Healingwish(), new Moves.Ingrain(), new Moves.Sweetscent(), new Moves.Worryseed() };
	public override int Weight => 66;
	public override int ExpYield => 56;
	public override int CatchRate => 190;
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