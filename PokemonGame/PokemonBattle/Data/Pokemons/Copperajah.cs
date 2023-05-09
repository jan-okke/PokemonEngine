using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Copperajah : Pokemon
{
	public override string Name => "Copperajah";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
	public override Stats BaseStats => new Stats(122, 130, 69, 80, 69, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Heavyslam() },
		[1] = new List<Move>() { new Moves.Heavyslam(), new Moves.Tackle(), new Moves.Growl(), new Moves.Rollout(), new Moves.Rocksmash() },
		[15] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Stomp() },
		[25] = new List<Move>() { new Moves.Irondefense() },
		[30] = new List<Move>() { new Moves.Dig() },
		[37] = new List<Move>() { new Moves.Strength() },
		[44] = new List<Move>() { new Moves.Ironhead() },
		[51] = new List<Move>() { new Moves.Playrough() },
		[58] = new List<Move>() { new Moves.Highhorsepower() },
		[65] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Playrough(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 6500;
	public override int ExpYield => 175;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}