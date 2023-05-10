using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Roselia : Pokemon
{
	public override string Name => "Roselia";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Poisonpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
	public override Stats BaseStats => new Stats(50, 60, 45, 100, 80, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Poisonsting() },
		[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Absorb(), new Moves.Growth(), new Moves.Stunspore(), new Moves.Worryseed() },
		[5] = new List<Move>() { new Moves.Megadrain() },
		[10] = new List<Move>() { new Moves.Leechseed() },
		[15] = new List<Move>() { new Moves.Magicalleaf() },
		[20] = new List<Move>() { new Moves.Toxicspikes() },
		[25] = new List<Move>() { new Moves.Sweetscent() },
		[30] = new List<Move>() { new Moves.Gigadrain() },
		[35] = new List<Move>() { new Moves.Synthesis() },
		[40] = new List<Move>() { new Moves.Toxic() },
		[45] = new List<Move>() { new Moves.Petalblizzard() },
		[50] = new List<Move>() { new Moves.Aromatherapy() },
		[55] = new List<Move>() { new Moves.Ingrain() },
		[60] = new List<Move>() { new Moves.Petaldance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Weatherball() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Cottonspore(), new Moves.Extrasensory(), new Moves.Leafstorm(), new Moves.Lifedew(), new Moves.Mindreader(), new Moves.Pinmissile(), new Moves.Powerwhip(), new Moves.Razorleaf(), new Moves.Seedbomb(), new Moves.Sleeppowder(), new Moves.Spikes(), new Moves.Synthesis() };
	public override int Weight => 20;
	public override int ExpYield => 140;
	public override int CatchRate => 150;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}