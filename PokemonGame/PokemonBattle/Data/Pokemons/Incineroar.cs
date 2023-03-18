using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Incineroar : Pokemon
	{
		public override string Name => "Incineroar";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(95, 115, 90, 80, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Darkestlariat() },
			[1] = new List<Move>() { new Darkestlariat(), new Crosschop(), new Throatchop(), new Bulkup(), new Scratch(), new Growl(), new Ember(), new Lick() },
			[9] = new List<Move>() { new Roar() },
			[12] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Doublekick() },
			[25] = new List<Move>() { new Firefang() },
			[30] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Swagger() },
			[44] = new List<Move>() { new Flamethrower() },
			[51] = new List<Move>() { new Thrash() },
			[58] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Blastburn(), new Blazekick(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Burningjealousy(), new Closecombat(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Lashout(), new Leechlife(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Outrage(), new Overheat(), new Payday(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swordsdance(), new Taunt(), new Throatchop(), new Thunderpunch(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 830;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}