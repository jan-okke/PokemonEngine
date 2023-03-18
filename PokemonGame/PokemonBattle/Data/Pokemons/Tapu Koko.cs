using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tapukoko : Pokemon
	{
		public override string Name => "Tapu Koko";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Electricsurge() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
		public override Stats BaseStats => new Stats(70, 115, 85, 95, 75, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Thundershock() },
			[5] = new List<Move>() { new Moves.Withdraw() },
			[10] = new List<Move>() { new Moves.Fairywind() },
			[15] = new List<Move>() { new Moves.Falseswipe() },
			[20] = new List<Move>() { new Moves.Spark() },
			[25] = new List<Move>() { new Moves.Shockwave() },
			[30] = new List<Move>() { new Moves.Charge() },
			[35] = new List<Move>() { new Moves.Agility() },
			[40] = new List<Move>() { new Moves.Screech() },
			[45] = new List<Move>() { new Moves.Discharge() },
			[50] = new List<Move>() { new Moves.Meanlook() },
			[55] = new List<Move>() { new Moves.Naturesmadness() },
			[60] = new List<Move>() { new Moves.Wildcharge() },
			[65] = new List<Move>() { new Moves.Bravebird() },
			[70] = new List<Move>() { new Moves.Powerswap() },
			[75] = new List<Move>() { new Moves.Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Assurance(), new Moves.Bravebird(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Workup() };
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