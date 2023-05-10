using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Budew : Pokemon
{
	public override string Name => "Budew";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Poisonpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
	public override Stats BaseStats => new Stats(40, 30, 35, 50, 70, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Growth(), new Moves.Stunspore(), new Moves.Worryseed() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Weatherball() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Cottonspore(), new Moves.Extrasensory(), new Moves.Leafstorm(), new Moves.Lifedew(), new Moves.Mindreader(), new Moves.Pinmissile(), new Moves.Razorleaf(), new Moves.Seedbomb(), new Moves.Sleeppowder(), new Moves.Spikes(), new Moves.Synthesis() };
	public override int Weight => 12;
	public override int ExpYield => 56;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}