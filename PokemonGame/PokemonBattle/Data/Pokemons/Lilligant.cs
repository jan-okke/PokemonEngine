using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lilligant : Pokemon
{
	public override string Name => "Lilligant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Owntempo() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
	public override Stats BaseStats => new Stats(70, 60, 75, 110, 75, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Petaldance() },
		[1] = new List<Move>() { new Moves.Petaldance(), new Moves.Petalblizzard(), new Moves.Quiverdance(), new Moves.Teeterdance(), new Moves.Megadrain(), new Moves.Aromatherapy(), new Moves.Magicalleaf(), new Moves.Sleeppowder(), new Moves.Gigadrain(), new Moves.Leechseed(), new Moves.Afteryou(), new Moves.Energyball(), new Moves.Synthesis(), new Moves.Sunnyday(), new Moves.Entrainment(), new Moves.Leafstorm(), new Moves.Absorb(), new Moves.Growth(), new Moves.Helpinghand(), new Moves.Stunspore() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance() };
	public override int Weight => 163;
	public override int ExpYield => 168;
	public override int CatchRate => 75;
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