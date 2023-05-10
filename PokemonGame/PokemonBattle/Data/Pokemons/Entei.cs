using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Entei : Pokemon
{
	public override string Name => "Entei";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(115, 115, 85, 90, 75, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sacredfire(), new Moves.Extremespeed(), new Moves.Ember(), new Moves.Leer(), new Moves.Stomp(), new Moves.Smokescreen() },
		[6] = new List<Move>() { new Moves.Flamewheel() },
		[12] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Calmmind() },
		[24] = new List<Move>() { new Moves.Roar() },
		[30] = new List<Move>() { new Moves.Firefang() },
		[36] = new List<Move>() { new Moves.Scaryface() },
		[42] = new List<Move>() { new Moves.Crunch() },
		[48] = new List<Move>() { new Moves.Extrasensory() },
		[54] = new List<Move>() { new Moves.Lavaplume() },
		[60] = new List<Move>() { new Moves.Swagger() },
		[66] = new List<Move>() { new Moves.Sunnyday() },
		[72] = new List<Move>() { new Moves.Fireblast() },
		[78] = new List<Move>() { new Moves.Eruption() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Overheat(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override int Weight => 1980;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}