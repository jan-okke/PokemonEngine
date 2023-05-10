using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lileep : Pokemon
{
	public override string Name => "Lileep";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Suctioncups() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stormdrain() };
	public override Stats BaseStats => new Stats(66, 41, 77, 61, 87, 23);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Astonish() },
		[4] = new List<Move>() { new Moves.Acid() },
		[8] = new List<Move>() { new Moves.Confuseray() },
		[12] = new List<Move>() { new Moves.Ingrain() },
		[16] = new List<Move>() { new Moves.Ancientpower() },
		[20] = new List<Move>() { new Moves.Megadrain() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Amnesia() },
		[32] = new List<Move>() { new Moves.Gastroacid() },
		[36] = new List<Move>() { new Moves.Gigadrain() },
		[41] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
		[44] = new List<Move>() { new Moves.Energyball() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulletseed(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bind(), new Moves.Curse(), new Moves.Megadrain(), new Moves.Mirrorcoat(), new Moves.Recover(), new Moves.Tickle() };
	public override int Weight => 238;
	public override int ExpYield => 71;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}