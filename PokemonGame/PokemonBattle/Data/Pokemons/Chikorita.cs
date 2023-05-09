using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Chikorita : Pokemon
{
	public override string Name => "Chikorita";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
	public override Stats BaseStats => new Stats(45, 49, 65, 49, 65, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[6] = new List<Move>() { new Moves.Razorleaf() },
		[9] = new List<Move>() { new Moves.Poisonpowder() },
		[12] = new List<Move>() { new Moves.Synthesis() },
		[17] = new List<Move>() { new Moves.Reflect() },
		[20] = new List<Move>() { new Moves.Magicalleaf() },
		[23] = new List<Move>() { new Moves.Naturepower() },
		[28] = new List<Move>() { new Moves.Sweetscent() },
		[31] = new List<Move>() { new Moves.Lightscreen() },
		[34] = new List<Move>() { new Moves.Bodyslam() },
		[39] = new List<Move>() { new Moves.Safeguard() },
		[42] = new List<Move>() { new Moves.Aromatherapy() },
		[45] = new List<Move>() { new Moves.Solarbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Workup(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Aromatherapy(), new Moves.Bodyslam(), new Moves.Counter(), new Moves.Flail(), new Moves.Grassyterrain(), new Moves.Healpulse(), new Moves.Ingrain(), new Moves.Leafstorm(), new Moves.Leechseed(), new Moves.Naturepower(), new Moves.Vinewhip() };
	public override int Weight => 64;
	public override int ExpYield => 64;
	public override int CatchRate => 45;
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