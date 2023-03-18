using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tapu Koko : Pokemon
	{
		public override string Name => "Tapu Koko";
		public override List<Ability> AvailableAbilities => new() {new Electricsurge() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(70, 115, 85, 130, 95, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Thundershock() },
			[5] = new List<Move>() { new Withdraw() },
			[10] = new List<Move>() { new Fairywind() },
			[15] = new List<Move>() { new Falseswipe() },
			[20] = new List<Move>() { new Spark() },
			[25] = new List<Move>() { new Shockwave() },
			[30] = new List<Move>() { new Charge() },
			[35] = new List<Move>() { new Agility() },
			[40] = new List<Move>() { new Screech() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Meanlook() },
			[55] = new List<Move>() { new Naturesmadness() },
			[60] = new List<Move>() { new Wildcharge() },
			[65] = new List<Move>() { new Bravebird() },
			[70] = new List<Move>() { new Powerswap() },
			[75] = new List<Move>() { new Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Bravebird(), new Calmmind(), new Dazzlinggleam(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Falseswipe(), new Fly(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Ironhead(), new Lightscreen(), new Powerswap(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Screech(), new Sleeptalk(), new Snore(), new Steelwing(), new Storedpower(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uturn(), new Voltswitch(), new Wildcharge(), new Workup() };
		public override int Weight => 205;
		public override int ExpYield => 285;
		public override int CatchRate => 3;
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