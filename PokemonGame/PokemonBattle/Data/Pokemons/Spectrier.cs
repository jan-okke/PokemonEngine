using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spectrier : Pokemon
	{
		public override string Name => "Spectrier";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Grimneigh() };
		public override Stats BaseStats => new Stats(100, 65, 60, 145, 80, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
			[6] = new List<Move>() { new Moves.Doublekick() },
			[12] = new List<Move>() { new Moves.Hex() },
			[18] = new List<Move>() { new Moves.Stomp() },
			[24] = new List<Move>() { new Moves.Confuseray() },
			[30] = new List<Move>() { new Moves.Haze() },
			[36] = new List<Move>() { new Moves.Shadowball() },
			[42] = new List<Move>() { new Moves.Takedown() },
			[48] = new List<Move>() { new Moves.Agility() },
			[54] = new List<Move>() { new Moves.Thrash() },
			[60] = new List<Move>() { new Moves.Disable() },
			[66] = new List<Move>() { new Moves.Doubleedge() },
			[72] = new List<Move>() { new Moves.Nastyplot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lashout(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Willowisp() };
		public override int Weight => 445;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}