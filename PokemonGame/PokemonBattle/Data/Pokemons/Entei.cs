using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Entei : Pokemon
	{
		public override string Name => "Entei";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(115, 115, 85, 100, 90, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sacredfire(), new Extremespeed(), new Ember(), new Leer(), new Stomp(), new Smokescreen() },
			[6] = new List<Move>() { new Flamewheel() },
			[12] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Calmmind() },
			[24] = new List<Move>() { new Roar() },
			[30] = new List<Move>() { new Firefang() },
			[36] = new List<Move>() { new Scaryface() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Extrasensory() },
			[54] = new List<Move>() { new Lavaplume() },
			[60] = new List<Move>() { new Swagger() },
			[66] = new List<Move>() { new Sunnyday() },
			[72] = new List<Move>() { new Fireblast() },
			[78] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flareblitz(), new Flash(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Overheat(), new Protect(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Reversal(), new Roar(), new Rockclimb(), new Rocksmash(), new Round(), new Sandstorm(), new Scaryface(), new Scorchingsands(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Weatherball(), new Willowisp() };
		public override int Weight => 1980;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}