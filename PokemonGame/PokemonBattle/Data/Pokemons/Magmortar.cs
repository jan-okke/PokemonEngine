using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Magmortar : Pokemon
{
	public override string Name => "Magmortar";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Vitalspirit() };
	public override Stats BaseStats => new Stats(75, 95, 67, 125, 95, 83);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Smog(), new Moves.Leer(), new Moves.Ember(), new Moves.Smokescreen() },
		[12] = new List<Move>() { new Moves.Clearsmog() },
		[16] = new List<Move>() { new Moves.Flamewheel() },
		[20] = new List<Move>() { new Moves.Confuseray() },
		[24] = new List<Move>() { new Moves.Scaryface() },
		[28] = new List<Move>() { new Moves.Firepunch() },
		[34] = new List<Move>() { new Moves.Lavaplume() },
		[40] = new List<Move>() { new Moves.Lowkick() },
		[46] = new List<Move>() { new Moves.Flamethrower() },
		[52] = new List<Move>() { new Moves.Sunnyday() },
		[58] = new List<Move>() { new Moves.Fireblast() },
		[64] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uproar(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override int Weight => 680;
	public override int ExpYield => 270;
	public override int CatchRate => 30;
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