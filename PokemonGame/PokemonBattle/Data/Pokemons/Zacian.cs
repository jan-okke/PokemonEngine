using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zacian : Pokemon
{
	public override string Name => "Zacian";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intrepidsword() };
	public override Stats BaseStats => new Stats(92, 130, 115, 80, 115, 138);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sacredsword(), new Moves.Quickguard(), new Moves.Metalclaw(), new Moves.Howl(), new Moves.Quickattack(), new Moves.Bite() },
		[11] = new List<Move>() { new Moves.Slash() },
		[22] = new List<Move>() { new Moves.Swordsdance() },
		[33] = new List<Move>() { new Moves.Ironhead() },
		[44] = new List<Move>() { new Moves.Laserfocus() },
		[55] = new List<Move>() { new Moves.Crunch() },
		[66] = new List<Move>() { new Moves.Moonblast() },
		[77] = new List<Move>() { new Moves.Closecombat() },
		[88] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firefang(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Imprison(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Psychocut(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Tailslap(), new Moves.Thunderfang(), new Moves.Wildcharge(), new Moves.Workup() };
	public override int Weight => 1100;
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