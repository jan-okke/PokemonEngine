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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
		public override Stats BaseStats => new Stats(50, 85, 55, 65, 65, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Tailwhip() },
			[10] = new List<Move>() { new Moves.Ember() },
			[15] = new List<Move>() { new Moves.Flamecharge() },
			[20] = new List<Move>() { new Moves.Agility() },
			[25] = new List<Move>() { new Moves.Flamewheel() },
			[30] = new List<Move>() { new Moves.Stomp() },
			[35] = new List<Move>() { new Moves.Firespin() },
			[41] = new List<Move>() { new Moves.Takedown() },
			[45] = new List<Move>() { new Moves.Inferno() },
			[50] = new List<Move>() { new Moves.Fireblast() },
			[55] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Wildcharge(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Doublekick(), new Moves.Flamewheel(), new Moves.Highhorsepower(), new Moves.Horndrill(), new Moves.Hypnosis(), new Moves.Lowkick(), new Moves.Morningsun(), new Moves.Thrash() };
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