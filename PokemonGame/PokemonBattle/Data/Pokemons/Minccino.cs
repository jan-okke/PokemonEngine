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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Skilllink() };
		public override Stats BaseStats => new Stats(55, 50, 40, 40, 40, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Babydolleyes() },
			[4] = new List<Move>() { new Moves.Helpinghand() },
			[8] = new List<Move>() { new Moves.Echoedvoice() },
			[12] = new List<Move>() { new Moves.Sing() },
			[16] = new List<Move>() { new Moves.Charm() },
			[20] = new List<Move>() { new Moves.Swift() },
			[24] = new List<Move>() { new Moves.Encore() },
			[28] = new List<Move>() { new Moves.Afteryou() },
			[32] = new List<Move>() { new Moves.Tailslap() },
			[36] = new List<Move>() { new Moves.Tickle() },
			[40] = new List<Move>() { new Moves.Slam() },
			[44] = new List<Move>() { new Moves.Hypervoice() },
			[48] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Flail(), new Moves.Knockoff(), new Moves.Tailwhip() };
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