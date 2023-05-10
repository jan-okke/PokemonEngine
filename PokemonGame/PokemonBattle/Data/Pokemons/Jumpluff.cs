using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Jumpluff : Pokemon
{
	public override string Name => "Jumpluff";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Leafguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(75, 55, 70, 55, 95, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash(), new Moves.Absorb(), new Moves.Synthesis(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Synthesis() },
		[6] = new List<Move>() { new Moves.Tailwhip() },
		[8] = new List<Move>() { new Moves.Tackle() },
		[10] = new List<Move>() { new Moves.Fairywind() },
		[12] = new List<Move>() { new Moves.Poisonpowder() },
		[14] = new List<Move>() { new Moves.Stunspore() },
		[16] = new List<Move>() { new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Bulletseed() },
		[24] = new List<Move>() { new Moves.Leechseed() },
		[29] = new List<Move>() { new Moves.Megadrain() },
		[34] = new List<Move>() { new Moves.Acrobatics() },
		[39] = new List<Move>() { new Moves.Ragepowder() },
		[44] = new List<Move>() { new Moves.Cottonspore() },
		[49] = new List<Move>() { new Moves.Uturn() },
		[54] = new List<Move>() { new Moves.Worryseed() },
		[59] = new List<Move>() { new Moves.Gigadrain() },
		[64] = new List<Move>() { new Moves.Bounce() },
		[69] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Uturn(), new Moves.Worryseed() };
	public override int Weight => 30;
	public override int ExpYield => 230;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}