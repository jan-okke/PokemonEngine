using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rapidash : Pokemon
	{
		public override string Name => "Rapidash";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
		public override Stats BaseStats => new Stats(65, 100, 70, 80, 80, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Smartstrike() },
			[1] = new List<Move>() { new Moves.Smartstrike(), new Moves.Megahorn(), new Moves.Poisonjab(), new Moves.Tackle(), new Moves.Quickattack(), new Moves.Growl(), new Moves.Tailwhip(), new Moves.Ember() },
			[15] = new List<Move>() { new Moves.Flamecharge() },
			[20] = new List<Move>() { new Moves.Agility() },
			[25] = new List<Move>() { new Moves.Flamewheel() },
			[30] = new List<Move>() { new Moves.Stomp() },
			[35] = new List<Move>() { new Moves.Firespin() },
			[43] = new List<Move>() { new Moves.Takedown() },
			[49] = new List<Move>() { new Moves.Inferno() },
			[56] = new List<Move>() { new Moves.Fireblast() },
			[63] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megahorn(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payday(), new Moves.Playrough(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Wildcharge(), new Moves.Willowisp() };
		public override int Weight => 950;
		public override int ExpYield => 175;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}