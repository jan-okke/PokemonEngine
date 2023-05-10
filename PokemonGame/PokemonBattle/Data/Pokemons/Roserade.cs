using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Roserade : Pokemon
{
	public override string Name => "Roserade";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Poisonpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(60, 70, 65, 125, 105, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Grassyterrain(), new Moves.Poisonsting(), new Moves.Venomdrench(), new Moves.Megadrain(), new Moves.Leechseed(), new Moves.Magicalleaf(), new Moves.Toxicspikes(), new Moves.Sweetscent(), new Moves.Gigadrain(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Petalblizzard(), new Moves.Aromatherapy(), new Moves.Ingrain(), new Moves.Petaldance(), new Moves.Absorb(), new Moves.Growth(), new Moves.Stunspore(), new Moves.Worryseed() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Weatherball() };
	public override int Weight => 145;
	public override int ExpYield => 258;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}