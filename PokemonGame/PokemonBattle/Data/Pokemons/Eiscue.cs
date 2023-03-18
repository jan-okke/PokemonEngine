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
		public override List<Ability> AvailableAbilities => new() {new Iceface() };
		public override Stats BaseStats => new Stats(75, 80, 110, 65, 90, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Tackle() },
			[6] = new List<Move>() { new Mist() },
			[12] = new List<Move>() { new Weatherball() },
			[18] = new List<Move>() { new Icywind() },
			[24] = new List<Move>() { new Headbutt() },
			[30] = new List<Move>() { new Amnesia() },
			[36] = new List<Move>() { new Freezedry() },
			[42] = new List<Move>() { new Hail() },
			[48] = new List<Move>() { new Auroraveil() },
			[54] = new List<Move>() { new Surf() },
			[60] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Brine(), new Dive(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Irondefense(), new Ironhead(), new Liquidation(), new Protect(), new Reflect(), new Rest(), new Reversal(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Waterfall(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Bellydrum(), new Doubleedge(), new Headsmash(), new Iciclecrash(), new Soak() };
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