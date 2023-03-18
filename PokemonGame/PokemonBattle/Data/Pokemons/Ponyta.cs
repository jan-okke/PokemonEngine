using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ponyta : Pokemon
	{
		public override string Name => "Ponyta";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flamebody() };
		public override Stats BaseStats => new Stats(50, 85, 55, 65, 65, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Tailwhip() },
			[10] = new List<Move>() { new Ember() },
			[15] = new List<Move>() { new Flamecharge() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Flamewheel() },
			[30] = new List<Move>() { new Stomp() },
			[35] = new List<Move>() { new Firespin() },
			[41] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Inferno() },
			[50] = new List<Move>() { new Fireblast() },
			[55] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Bodyslam(), new Bounce(), new Charm(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Heatwave(), new Hiddenpower(), new Highhorsepower(), new Irontail(), new Lowkick(), new Mysticalfire(), new Overheat(), new Playrough(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Wildcharge(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Allyswitch(), new Charm(), new Doubleedge(), new Doublekick(), new Flamewheel(), new Highhorsepower(), new Horndrill(), new Hypnosis(), new Lowkick(), new Morningsun(), new Thrash() };
		public override int Weight => 300;
		public override int ExpYield => 82;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}