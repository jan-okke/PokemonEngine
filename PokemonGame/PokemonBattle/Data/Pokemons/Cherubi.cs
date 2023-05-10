using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cherubi : Pokemon
{
	public override string Name => "Cherubi";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
	public override Stats BaseStats => new Stats(45, 35, 45, 62, 53, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Morningsun(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Leafage() },
		[10] = new List<Move>() { new Moves.Growth() },
		[15] = new List<Move>() { new Moves.Helpinghand() },
		[20] = new List<Move>() { new Moves.Magicalleaf() },
		[26] = new List<Move>() { new Moves.Leechseed() },
		[30] = new List<Move>() { new Moves.Takedown() },
		[35] = new List<Move>() { new Moves.Petalblizzard() },
		[40] = new List<Move>() { new Moves.Worryseed() },
		[45] = new List<Move>() { new Moves.Solarbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Magicalleaf(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Weatherball() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aromatherapy(), new Moves.Defensecurl(), new Moves.Flowershield(), new Moves.Grassyterrain(), new Moves.Healingwish(), new Moves.Healpulse(), new Moves.Naturepower(), new Moves.Razorleaf(), new Moves.Rollout(), new Moves.Seedbomb(), new Moves.Sweetscent(), new Moves.Tickle(), new Moves.Weatherball() };
	public override int Weight => 33;
	public override int ExpYield => 55;
	public override int CatchRate => 190;
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