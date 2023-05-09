using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rockruff : Pokemon
{
	public override string Name => "Rockruff";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Vitalspirit() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(45, 65, 40, 30, 40, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[8] = new List<Move>() { new Moves.Doubleteam() },
		[12] = new List<Move>() { new Moves.Rockthrow() },
		[16] = new List<Move>() { new Moves.Howl() },
		[20] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Rocktomb() },
		[28] = new List<Move>() { new Moves.Roar() },
		[32] = new List<Move>() { new Moves.Rockslide() },
		[36] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Scaryface() },
		[44] = new List<Move>() { new Moves.Stealthrock() },
		[48] = new List<Move>() { new Moves.Stoneedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Crunch(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderfang(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Endeavor(), new Moves.Lastresort(), new Moves.Thrash() };
	public override int Weight => 92;
	public override int ExpYield => 56;
	public override int CatchRate => 190;
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