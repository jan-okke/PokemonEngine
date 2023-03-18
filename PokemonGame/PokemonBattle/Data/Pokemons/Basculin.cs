using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Basculin : Pokemon
	{
		public override string Name => "Basculin";
		public override List<Ability> AvailableAbilities => new() {new Reckless(), new Adaptability() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(70, 92, 65, 80, 55, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Tailwhip() },
			[4] = new List<Move>() { new Tackle() },
			[8] = new List<Move>() { new Flail() },
			[12] = new List<Move>() { new Aquajet() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Soak() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Takedown() },
			[40] = new List<Move>() { new Finalgambit() },
			[44] = new List<Move>() { new Aquatail() },
			[48] = new List<Move>() { new Thrash() },
			[52] = new List<Move>() { new Doubleedge() },
			[56] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Brine(), new Crunch(), new Dive(), new Endure(), new Facade(), new Flipturn(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icefang(), new Icywind(), new Liquidation(), new Muddywater(), new Mudshot(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Revenge(), new Reversal(), new Round(), new Scald(), new Scaleshot(), new Scaryface(), new Sleeptalk(), new Snore(), new Substitute(), new Superpower(), new Surf(), new Swift(), new Taunt(), new Uproar(), new Waterfall(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Bubblebeam(), new Endeavor() };
		public override int Weight => 180;
		public override int ExpYield => 161;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}