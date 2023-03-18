using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arctovish : Pokemon
	{
		public override string Name => "Arctovish";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Slushrush() };
		public override Stats BaseStats => new Stats(90, 90, 100, 80, 90, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Watergun() },
			[7] = new List<Move>() { new Moves.Protect() },
			[14] = new List<Move>() { new Moves.Icywind() },
			[21] = new List<Move>() { new Moves.Ancientpower() },
			[28] = new List<Move>() { new Moves.Bite() },
			[35] = new List<Move>() { new Moves.Auroraveil() },
			[42] = new List<Move>() { new Moves.Freezedry() },
			[49] = new List<Move>() { new Moves.Superfang() },
			[56] = new List<Move>() { new Moves.Crunch() },
			[63] = new List<Move>() { new Moves.Fishiousrend() },
			[70] = new List<Move>() { new Moves.Iciclecrash() },
			[77] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Crunch(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
		public override int Weight => 1750;
		public override int ExpYield => 177;
		public override int CatchRate => 45;
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