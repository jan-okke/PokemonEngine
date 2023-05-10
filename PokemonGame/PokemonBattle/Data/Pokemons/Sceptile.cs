using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sceptile : Pokemon
{
	public override string Name => "Sceptile";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unburden() };
	public override Stats BaseStats => new Stats(70, 85, 65, 105, 85, 120);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Dualchop() },
		[1] = new List<Move>() { new Moves.Dualchop(), new Moves.Furycutter(), new Moves.Falseswipe(), new Moves.Xscissor(), new Moves.Energyball(), new Moves.Pound(), new Moves.Leer(), new Moves.Leafage(), new Moves.Quickattack() },
		[5] = new List<Move>() { new Moves.Megadrain() },
		[12] = new List<Move>() { new Moves.Detect() },
		[15] = new List<Move>() { new Moves.Quickguard() },
		[20] = new List<Move>() { new Moves.Assurance() },
		[25] = new List<Move>() { new Moves.Gigadrain() },
		[30] = new List<Move>() { new Moves.Slam() },
		[35] = new List<Move>() { new Moves.Doubleteam() },
		[42] = new List<Move>() { new Moves.Leafblade() },
		[49] = new List<Move>() { new Moves.Screech() },
		[56] = new List<Move>() { new Moves.Endeavor() },
		[63] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Crosspoison(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frenzyplant(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Xscissor() };
	public override int Weight => 522;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}