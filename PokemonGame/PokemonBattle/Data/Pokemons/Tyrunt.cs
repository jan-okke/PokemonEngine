using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tyrunt : Pokemon
{
	public override string Name => "Tyrunt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(58, 89, 77, 45, 45, 48);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Roar() },
		[8] = new List<Move>() { new Moves.Ancientpower() },
		[12] = new List<Move>() { new Moves.Charm() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Dragontail() },
		[24] = new List<Move>() { new Moves.Stomp() },
		[28] = new List<Move>() { new Moves.Rockslide() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Dragonclaw() },
		[40] = new List<Move>() { new Moves.Thrash() },
		[44] = new List<Move>() { new Moves.Earthquake() },
		[48] = new List<Move>() { new Moves.Horndrill() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Thunderfang(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Poisonfang(), new Moves.Rockpolish(), new Moves.Rockthrow() };
	public override int Weight => 260;
	public override int ExpYield => 72;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}