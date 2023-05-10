using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Eldegoss : Pokemon
{
	public override string Name => "Eldegoss";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cottondown(), new Abilities.Regenerator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Effectspore() };
	public override Stats BaseStats => new Stats(60, 50, 90, 80, 120, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Cottonspore() },
		[1] = new List<Move>() { new Moves.Cottonspore(), new Moves.Leafage(), new Moves.Sing(), new Moves.Rapidspin(), new Moves.Sweetscent() },
		[12] = new List<Move>() { new Moves.Razorleaf() },
		[16] = new List<Move>() { new Moves.Round() },
		[23] = new List<Move>() { new Moves.Leaftornado() },
		[28] = new List<Move>() { new Moves.Synthesis() },
		[34] = new List<Move>() { new Moves.Hypervoice() },
		[40] = new List<Move>() { new Moves.Aromatherapy() },
		[46] = new List<Move>() { new Moves.Leafstorm() },
		[52] = new List<Move>() { new Moves.Cottonguard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Weatherball() };
	public override int Weight => 25;
	public override int ExpYield => 161;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}