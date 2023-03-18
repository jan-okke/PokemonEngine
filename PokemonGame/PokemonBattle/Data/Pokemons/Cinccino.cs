using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cinccino : Pokemon
	{
		public override string Name => "Cinccino";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Skilllink() };
		public override Stats BaseStats => new Stats(75, 95, 60, 115, 65, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bulletseed(), new Rockblast(), new Sing(), new Charm(), new Swift(), new Encore(), new Afteryou(), new Tailslap(), new Tickle(), new Slam(), new Hypervoice(), new Lastresort(), new Pound(), new Babydolleyes(), new Helpinghand(), new Echoedvoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Dig(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fling(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lightscreen(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockblast(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Tailslap(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Tripleaxel(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 75;
		public override int ExpYield => 165;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}