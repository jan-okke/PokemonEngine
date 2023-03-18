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
		public override List<Ability> AvailableAbilities => new() {new Grimneigh() };
		public override Stats BaseStats => new Stats(100, 65, 60, 130, 145, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[6] = new List<Move>() { new Doublekick() },
			[12] = new List<Move>() { new Hex() },
			[18] = new List<Move>() { new Stomp() },
			[24] = new List<Move>() { new Confuseray() },
			[30] = new List<Move>() { new Haze() },
			[36] = new List<Move>() { new Shadowball() },
			[42] = new List<Move>() { new Takedown() },
			[48] = new List<Move>() { new Agility() },
			[54] = new List<Move>() { new Thrash() },
			[60] = new List<Move>() { new Disable() },
			[66] = new List<Move>() { new Doubleedge() },
			[72] = new List<Move>() { new Nastyplot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Crunch(), new Darkpulse(), new Endure(), new Facade(), new Foulplay(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Lashout(), new Mudshot(), new Nastyplot(), new Payback(), new Phantomforce(), new Protect(), new Psychocut(), new Rest(), new Round(), new Scaryface(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Swift(), new Taunt(), new Uproar(), new Willowisp() };
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