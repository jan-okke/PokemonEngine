using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cradily : Pokemon
{
	public override string Name => "Cradily";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Suctioncups() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stormdrain() };
	public override Stats BaseStats => new Stats(86, 81, 97, 81, 107, 43);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leechseed(), new Moves.Wrap(), new Moves.Astonish(), new Moves.Acid(), new Moves.Confuseray() },
		[12] = new List<Move>() { new Moves.Ingrain() },
		[16] = new List<Move>() { new Moves.Ancientpower() },
		[20] = new List<Move>() { new Moves.Megadrain() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Amnesia() },
		[32] = new List<Move>() { new Moves.Gastroacid() },
		[36] = new List<Move>() { new Moves.Gigadrain() },
		[43] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
		[48] = new List<Move>() { new Moves.Energyball() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance() };
	public override int Weight => 604;
	public override int ExpYield => 173;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}