using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gossifleur : Pokemon
{
	public override string Name => "Gossifleur";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cottondown(), new Abilities.Regenerator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Effectspore() };
	public override Stats BaseStats => new Stats(40, 40, 60, 40, 60, 10);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leafage(), new Moves.Sing() },
		[4] = new List<Move>() { new Moves.Rapidspin() },
		[8] = new List<Move>() { new Moves.Sweetscent() },
		[12] = new List<Move>() { new Moves.Razorleaf() },
		[16] = new List<Move>() { new Moves.Round() },
		[21] = new List<Move>() { new Moves.Leaftornado() },
		[24] = new List<Move>() { new Moves.Synthesis() },
		[28] = new List<Move>() { new Moves.Hypervoice() },
		[32] = new List<Move>() { new Moves.Aromatherapy() },
		[36] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Growth(), new Moves.Leechseed(), new Moves.Poisonpowder(), new Moves.Sleeppowder(), new Moves.Stunspore(), new Moves.Worryseed() };
	public override int Weight => 22;
	public override int ExpYield => 50;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}