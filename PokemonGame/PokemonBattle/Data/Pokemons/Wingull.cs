using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wingull : Pokemon
	{
		public override string Name => "Wingull";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(40, 30, 30, 85, 55, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Watergun() },
			[5] = new List<Move>() { new Quickattack() },
			[10] = new List<Move>() { new Supersonic() },
			[15] = new List<Move>() { new Wingattack() },
			[20] = new List<Move>() { new Waterpulse() },
			[26] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Airslash() },
			[35] = new List<Move>() { new Mist() },
			[40] = new List<Move>() { new Roost() },
			[45] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Attract(), new Blizzard(), new Brine(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Hail(), new Hiddenpower(), new Hurricane(), new Icebeam(), new Icywind(), new Liquidation(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Roost(), new Round(), new Scald(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Uturn(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Aircutter(), new Aquaring(), new Gust(), new Knockoff(), new Mist(), new Soak(), new Twister(), new Wideguard() };
		public override int Weight => 95;
		public override int ExpYield => 54;
		public override int CatchRate => 190;
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