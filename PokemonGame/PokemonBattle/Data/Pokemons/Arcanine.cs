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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Justified() };
		public override Stats BaseStats => new Stats(90, 110, 80, 100, 80, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Extremespeed() },
			[1] = new List<Move>() { new Moves.Extremespeed(), new Moves.Burnup(), new Moves.Flamewheel(), new Moves.Helpinghand(), new Moves.Agility(), new Moves.Firefang(), new Moves.Retaliate(), new Moves.Crunch(), new Moves.Takedown(), new Moves.Flamethrower(), new Moves.Roar(), new Moves.Playrough(), new Moves.Reversal(), new Moves.Flareblitz(), new Moves.Ember(), new Moves.Leer(), new Moves.Howl(), new Moves.Bite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Wildcharge(), new Moves.Willowisp() };
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