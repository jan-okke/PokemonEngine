using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Venusaur : Pokemon
{
	public override string Name => "Venusaur";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Chlorophyll() };
	public override Stats BaseStats => new Stats(80, 82, 83, 100, 100, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Petalblizzard() },
		[1] = new List<Move>() { new Moves.Petalblizzard(), new Moves.Petaldance(), new Moves.Tackle(), new Moves.Growl(), new Moves.Vinewhip(), new Moves.Growth() },
		[9] = new List<Move>() { new Moves.Leechseed() },
		[12] = new List<Move>() { new Moves.Razorleaf() },
		[15] = new List<Move>() { new Moves.Poisonpowder(), new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Seedbomb() },
		[25] = new List<Move>() { new Moves.Takedown() },
		[30] = new List<Move>() { new Moves.Sweetscent() },
		[37] = new List<Move>() { new Moves.Synthesis() },
		[44] = new List<Move>() { new Moves.Worryseed() },
		[51] = new List<Move>() { new Moves.Doubleedge() },
		[58] = new List<Move>() { new Moves.Solarbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frenzyplant(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Outrage(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Toxic(), new Moves.Venoshock(), new Moves.Weatherball(), new Moves.Workup() };
	public override int Weight => 1000;
	public override int ExpYield => 263;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}