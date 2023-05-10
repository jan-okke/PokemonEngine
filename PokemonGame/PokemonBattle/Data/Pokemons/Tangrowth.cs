using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tangrowth : Pokemon
{
	public override string Name => "Tangrowth";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Leafguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(100, 100, 125, 110, 50, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Block(), new Moves.Absorb(), new Moves.Bind(), new Moves.Stunspore(), new Moves.Growth() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Vinewhip() },
		[20] = new List<Move>() { new Moves.Poisonpowder() },
		[24] = new List<Move>() { new Moves.Ancientpower() },
		[28] = new List<Move>() { new Moves.Knockoff() },
		[32] = new List<Move>() { new Moves.Gigadrain() },
		[36] = new List<Move>() { new Moves.Sleeppowder() },
		[40] = new List<Move>() { new Moves.Slam() },
		[44] = new List<Move>() { new Moves.Tickle() },
		[48] = new List<Move>() { new Moves.Powerwhip() },
		[52] = new List<Move>() { new Moves.Ingrain() },
		[56] = new List<Move>() { new Moves.Grassyterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Powerswap(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief() };
	public override int Weight => 1286;
	public override int ExpYield => 187;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}