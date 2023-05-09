using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Heatran : Pokemon
{
	public override string Name => "Heatran";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
	public override Stats BaseStats => new Stats(91, 90, 106, 130, 106, 77);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Firespin(), new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Metalclaw() },
		[12] = new List<Move>() { new Moves.Ancientpower() },
		[18] = new List<Move>() { new Moves.Firefang() },
		[24] = new List<Move>() { new Moves.Scaryface() },
		[30] = new List<Move>() { new Moves.Ironhead() },
		[36] = new List<Move>() { new Moves.Crunch() },
		[42] = new List<Move>() { new Moves.Lavaplume() },
		[48] = new List<Move>() { new Moves.Metalsound() },
		[54] = new List<Move>() { new Moves.Earthpower() },
		[60] = new List<Move>() { new Moves.Heatwave() },
		[66] = new List<Move>() { new Moves.Stoneedge() },
		[72] = new List<Move>() { new Moves.Magmastorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Torment(), new Moves.Uproar(), new Moves.Willowisp() };
	public override int Weight => 4300;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}