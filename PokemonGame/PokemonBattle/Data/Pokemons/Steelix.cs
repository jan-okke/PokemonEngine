using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Steelix : Pokemon
{
	public override string Name => "Steelix";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead(), new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(75, 85, 200, 55, 65, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Crunch(), new Moves.Thunderfang(), new Moves.Icefang(), new Moves.Firefang(), new Moves.Rockpolish(), new Moves.Tackle(), new Moves.Harden(), new Moves.Bind(), new Moves.Rockthrow() },
		[4] = new List<Move>() { new Moves.Smackdown() },
		[8] = new List<Move>() { new Moves.Autotomize() },
		[12] = new List<Move>() { new Moves.Dragonbreath() },
		[16] = new List<Move>() { new Moves.Curse() },
		[20] = new List<Move>() { new Moves.Rockslide() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Sandtomb() },
		[32] = new List<Move>() { new Moves.Stealthrock() },
		[36] = new List<Move>() { new Moves.Slam() },
		[40] = new List<Move>() { new Moves.Sandstorm() },
		[44] = new List<Move>() { new Moves.Dig() },
		[48] = new List<Move>() { new Moves.Irontail() },
		[52] = new List<Move>() { new Moves.Stoneedge() },
		[56] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Magnetrise() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Firefang(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Meteorbeam(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Psychup(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunderfang(), new Moves.Torment() };
	public override int Weight => 4000;
	public override int ExpYield => 179;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}