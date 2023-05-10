using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mantyke : Pokemon
{
	public override string Name => "Mantyke";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Waterabsorb() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterveil() };
	public override Stats BaseStats => new Stats(45, 20, 50, 60, 120, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Watergun() },
		[4] = new List<Move>() { new Moves.Supersonic() },
		[8] = new List<Move>() { new Moves.Wingattack() },
		[12] = new List<Move>() { new Moves.Waterpulse() },
		[16] = new List<Move>() { new Moves.Wideguard() },
		[20] = new List<Move>() { new Moves.Agility() },
		[24] = new List<Move>() { new Moves.Bubblebeam() },
		[28] = new List<Move>() { new Moves.Headbutt() },
		[32] = new List<Move>() { new Moves.Airslash() },
		[36] = new List<Move>() { new Moves.Aquaring() },
		[40] = new List<Move>() { new Moves.Bounce() },
		[44] = new List<Move>() { new Moves.Takedown() },
		[48] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Confuseray(), new Moves.Haze(), new Moves.Hydropump(), new Moves.Mirrorcoat(), new Moves.Slam(), new Moves.Splash(), new Moves.Tailwind(), new Moves.Twister(), new Moves.Wideguard() };
	public override int Weight => 650;
	public override int ExpYield => 69;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}