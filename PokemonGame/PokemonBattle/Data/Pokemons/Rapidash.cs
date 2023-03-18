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
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flamebody() };
		public override Stats BaseStats => new Stats(65, 100, 70, 80, 80, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Smartstrike() },
			[1] = new List<Move>() { new Smartstrike(), new Megahorn(), new Poisonjab(), new Tackle(), new Quickattack(), new Growl(), new Tailwhip(), new Ember() },
			[15] = new List<Move>() { new Flamecharge() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Flamewheel() },
			[30] = new List<Move>() { new Stomp() },
			[35] = new List<Move>() { new Firespin() },
			[43] = new List<Move>() { new Takedown() },
			[49] = new List<Move>() { new Inferno() },
			[56] = new List<Move>() { new Fireblast() },
			[63] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Batonpass(), new Bodyslam(), new Bounce(), new Charm(), new Doubleteam(), new Drillrun(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Megahorn(), new Mysticalfire(), new Overheat(), new Payday(), new Playrough(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Scorchingsands(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Solarblade(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Throatchop(), new Wildcharge(), new Willowisp() };
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