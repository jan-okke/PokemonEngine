using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eiscue : Pokemon
	{
		public override string Name => "Eiscue";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Iceface() };
		public override Stats BaseStats => new Stats(75, 80, 110, 65, 90, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Tackle() },
			[6] = new List<Move>() { new Moves.Mist() },
			[12] = new List<Move>() { new Moves.Weatherball() },
			[18] = new List<Move>() { new Moves.Icywind() },
			[24] = new List<Move>() { new Moves.Headbutt() },
			[30] = new List<Move>() { new Moves.Amnesia() },
			[36] = new List<Move>() { new Moves.Freezedry() },
			[42] = new List<Move>() { new Moves.Hail() },
			[48] = new List<Move>() { new Moves.Auroraveil() },
			[54] = new List<Move>() { new Moves.Surf() },
			[60] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Bellydrum(), new Moves.Doubleedge(), new Moves.Headsmash(), new Moves.Iciclecrash(), new Moves.Soak() };
		public override int Weight => 890;
		public override int ExpYield => 165;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}