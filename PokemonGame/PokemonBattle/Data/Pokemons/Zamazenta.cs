using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zamazenta : Pokemon
	{
		public override string Name => "Zamazenta";
		public override List<Ability> AvailableAbilities => new() {new Dauntlessshield() };
		public override Stats BaseStats => new Stats(92, 130, 115, 138, 80, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Metalburst(), new Wideguard(), new Metalclaw(), new Howl(), new Quickattack(), new Bite() },
			[11] = new List<Move>() { new Slash() },
			[22] = new List<Move>() { new Irondefense() },
			[33] = new List<Move>() { new Ironhead() },
			[44] = new List<Move>() { new Laserfocus() },
			[55] = new List<Move>() { new Crunch() },
			[66] = new List<Move>() { new Moonblast() },
			[77] = new List<Move>() { new Closecombat() },
			[88] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Closecombat(), new Coaching(), new Crunch(), new Dazzlinggleam(), new Dig(), new Endure(), new Facade(), new Firefang(), new Flashcannon(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icefang(), new Imprison(), new Irondefense(), new Ironhead(), new Irontail(), new Lightscreen(), new Payback(), new Playrough(), new Powerswap(), new Protect(), new Psychicfangs(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Safeguard(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Steelbeam(), new Substitute(), new Swift(), new Tailslap(), new Thunderfang(), new Wildcharge(), new Workup() };
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
}