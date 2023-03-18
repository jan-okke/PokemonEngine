using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arcanine : Pokemon
	{
		public override string Name => "Arcanine";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(90, 110, 80, 100, 80, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Extremespeed() },
			[1] = new List<Move>() { new Extremespeed(), new Burnup(), new Flamewheel(), new Helpinghand(), new Agility(), new Firefang(), new Retaliate(), new Crunch(), new Takedown(), new Flamethrower(), new Roar(), new Playrough(), new Reversal(), new Flareblitz(), new Ember(), new Leer(), new Howl(), new Bite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Crunch(), new Dig(), new Doubleteam(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flareblitz(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Ironhead(), new Irontail(), new Outrage(), new Overheat(), new Playrough(), new Protect(), new Psychicfangs(), new Rest(), new Retaliate(), new Reversal(), new Roar(), new Rockclimb(), new Rocksmash(), new Round(), new Safeguard(), new Scaryface(), new Scorchingsands(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunderfang(), new Wildcharge(), new Willowisp() };
		public override int Weight => 1550;
		public override int ExpYield => 194;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}