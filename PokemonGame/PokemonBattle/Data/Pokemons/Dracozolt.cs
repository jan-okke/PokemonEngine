using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dracozolt : Pokemon
{
	public override string Name => "Dracozolt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Voltabsorb(), new Abilities.Hustle() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandrush() };
	public override Stats BaseStats => new Stats(90, 100, 90, 80, 70, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Thundershock() },
		[7] = new List<Move>() { new Moves.Charge() },
		[14] = new List<Move>() { new Moves.Aerialace() },
		[21] = new List<Move>() { new Moves.Ancientpower() },
		[28] = new List<Move>() { new Moves.Pluck() },
		[35] = new List<Move>() { new Moves.Dragontail() },
		[42] = new List<Move>() { new Moves.Stomp() },
		[49] = new List<Move>() { new Moves.Slam() },
		[56] = new List<Move>() { new Moves.Discharge() },
		[63] = new List<Move>() { new Moves.Boltbeak() },
		[70] = new List<Move>() { new Moves.Dragonpulse() },
		[77] = new List<Move>() { new Moves.Dragonrush() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Wildcharge() };
	public override int Weight => 1900;
	public override int ExpYield => 177;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}