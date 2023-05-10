using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lycanroc : Pokemon
{
	public override string Name => "Lycanroc";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Sandrush() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(75, 115, 65, 55, 65, 112);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Suckerpunch() },
		[1] = new List<Move>() { new Moves.Suckerpunch(), new Moves.Accelerock(), new Moves.Quickguard(), new Moves.Quickattack(), new Moves.Tackle(), new Moves.Leer(), new Moves.Sandattack(), new Moves.Doubleteam() },
		[12] = new List<Move>() { new Moves.Rockthrow() },
		[16] = new List<Move>() { new Moves.Howl() },
		[20] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Rocktomb() },
		[30] = new List<Move>() { new Moves.Roar() },
		[36] = new List<Move>() { new Moves.Rockslide() },
		[42] = new List<Move>() { new Moves.Crunch() },
		[48] = new List<Move>() { new Moves.Scaryface() },
		[54] = new List<Move>() { new Moves.Stealthrock() },
		[60] = new List<Move>() { new Moves.Stoneedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Tailslap(), new Moves.Taunt(), new Moves.Thunderfang(), new Moves.Zenheadbutt() };
	public override int Weight => 250;
	public override int ExpYield => 170;
	public override int CatchRate => 90;
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