using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meltan : Pokemon
	{
		public override string Name => "Meltan";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Magnetpull() };
		public override Stats BaseStats => new Stats(46, 65, 65, 55, 35, 34);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Harden() },
			[8] = new List<Move>() { new Moves.Tailwhip() },
			[16] = new List<Move>() { new Moves.Headbutt() },
			[24] = new List<Move>() { new Moves.Thunderwave() },
			[32] = new List<Move>() { new Moves.Acidarmor() },
			[40] = new List<Move>() { new Moves.Flashcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave() };
		public override int Weight => 80;
		public override int ExpYield => 150;
		public override int CatchRate => 3;
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
}