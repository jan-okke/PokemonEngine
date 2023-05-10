using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vibrava : Pokemon
{
	public override string Name => "Vibrava";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(50, 70, 50, 50, 50, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Dragonbreath() },
		[1] = new List<Move>() { new Moves.Dragonbreath(), new Moves.Laserfocus(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Crunch(), new Moves.Superpower(), new Moves.Fissure(), new Moves.Sandattack(), new Moves.Astonish(), new Moves.Supersonic(), new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Mudslap() },
		[16] = new List<Move>() { new Moves.Sandtomb() },
		[20] = new List<Move>() { new Moves.Dragontail() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Bugbuzz() },
		[32] = new List<Move>() { new Moves.Sandstorm() },
		[38] = new List<Move>() { new Moves.Earthpower() },
		[44] = new List<Move>() { new Moves.Earthquake() },
		[50] = new List<Move>() { new Moves.Uproar() },
		[56] = new List<Move>() { new Moves.Dragonrush() },
		[62] = new List<Move>() { new Moves.Boomburst() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bugbuzz(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigadrain(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Uturn() };
	public override int Weight => 153;
	public override int ExpYield => 119;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}