using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Foongus : Pokemon
{
	public override string Name => "Foongus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(69, 55, 45, 55, 55, 15);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Astonish() },
		[4] = new List<Move>() { new Moves.Growth() },
		[8] = new List<Move>() { new Moves.Stunspore() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Synthesis() },
		[20] = new List<Move>() { new Moves.Clearsmog() },
		[24] = new List<Move>() { new Moves.Sweetscent() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Ingrain() },
		[36] = new List<Move>() { new Moves.Toxic() },
		[40] = new List<Move>() { new Moves.Ragepowder() },
		[44] = new List<Move>() { new Moves.Solarbeam() },
		[48] = new List<Move>() { new Moves.Spore() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Payback(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Poisonpowder(), new Moves.Rollout(), new Moves.Worryseed() };
	public override int Weight => 10;
	public override int ExpYield => 59;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}