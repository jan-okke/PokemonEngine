using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Incineroar : Pokemon
{
	public override string Name => "Incineroar";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Intimidate() };
	public override Stats BaseStats => new Stats(95, 115, 90, 80, 90, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Darkestlariat() },
		[1] = new List<Move>() { new Moves.Darkestlariat(), new Moves.Crosschop(), new Moves.Throatchop(), new Moves.Bulkup(), new Moves.Scratch(), new Moves.Growl(), new Moves.Ember(), new Moves.Lick() },
		[9] = new List<Move>() { new Moves.Roar() },
		[12] = new List<Move>() { new Moves.Furyswipes() },
		[15] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Doublekick() },
		[25] = new List<Move>() { new Moves.Firefang() },
		[30] = new List<Move>() { new Moves.Scaryface() },
		[32] = new List<Move>() { new Moves.Swagger() },
		[44] = new List<Move>() { new Moves.Flamethrower() },
		[51] = new List<Move>() { new Moves.Thrash() },
		[58] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Blastburn(), new Moves.Blazekick(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Leechlife(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payday(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
	public override int Weight => 830;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}