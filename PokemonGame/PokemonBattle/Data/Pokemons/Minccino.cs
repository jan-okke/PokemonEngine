using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Minccino : Pokemon
	{
		public override string Name => "Minccino";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Skilllink() };
		public override Stats BaseStats => new Stats(55, 50, 40, 75, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Babydolleyes() },
			[4] = new List<Move>() { new Helpinghand() },
			[8] = new List<Move>() { new Echoedvoice() },
			[12] = new List<Move>() { new Sing() },
			[16] = new List<Move>() { new Charm() },
			[20] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Encore() },
			[28] = new List<Move>() { new Afteryou() },
			[32] = new List<Move>() { new Tailslap() },
			[36] = new List<Move>() { new Tickle() },
			[40] = new List<Move>() { new Slam() },
			[44] = new List<Move>() { new Hypervoice() },
			[48] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Dig(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fling(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Tailslap(), new Thief(), new Thunderbolt(), new Thunderwave(), new Tripleaxel(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aquatail(), new Flail(), new Knockoff(), new Tailwhip() };
		public override int Weight => 58;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}