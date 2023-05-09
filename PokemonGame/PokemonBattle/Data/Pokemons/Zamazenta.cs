using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zamazenta : Pokemon
{
	public override string Name => "Zamazenta";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Dauntlessshield() };
	public override Stats BaseStats => new Stats(92, 130, 115, 80, 115, 138);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Metalburst(), new Moves.Wideguard(), new Moves.Metalclaw(), new Moves.Howl(), new Moves.Quickattack(), new Moves.Bite() },
		[11] = new List<Move>() { new Moves.Slash() },
		[22] = new List<Move>() { new Moves.Irondefense() },
		[33] = new List<Move>() { new Moves.Ironhead() },
		[44] = new List<Move>() { new Moves.Laserfocus() },
		[55] = new List<Move>() { new Moves.Crunch() },
		[66] = new List<Move>() { new Moves.Moonblast() },
		[77] = new List<Move>() { new Moves.Closecombat() },
		[88] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Flashcannon(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Payback(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thunderfang(), new Moves.Wildcharge(), new Moves.Workup() };
	public override int Weight => 2100;
	public override int ExpYield => 335;
	public override int CatchRate => 10;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}