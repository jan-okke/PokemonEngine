using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Skiploom : Pokemon
{
	public override string Name => "Skiploom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Leafguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(55, 45, 50, 45, 65, 80);
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
		[28] = new List<Move>() { new Moves.Megadrain() },
		[32] = new List<Move>() { new Moves.Acrobatics() },
		[36] = new List<Move>() { new Moves.Ragepowder() },
		[40] = new List<Move>() { new Moves.Cottonspore() },
		[44] = new List<Move>() { new Moves.Uturn() },
		[48] = new List<Move>() { new Moves.Worryseed() },
		[52] = new List<Move>() { new Moves.Gigadrain() },
		[56] = new List<Move>() { new Moves.Bounce() },
		[60] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Uturn(), new Moves.Worryseed() };
	public override int Weight => 10;
	public override int ExpYield => 119;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}