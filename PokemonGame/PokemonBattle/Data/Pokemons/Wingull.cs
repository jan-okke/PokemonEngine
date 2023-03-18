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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
		public override Stats BaseStats => new Stats(40, 30, 30, 55, 30, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Growl(), new Moves.Watergun() },
			[5] = new List<Move>() { new Moves.Quickattack() },
			[10] = new List<Move>() { new Moves.Supersonic() },
			[15] = new List<Move>() { new Moves.Wingattack() },
			[20] = new List<Move>() { new Moves.Waterpulse() },
			[26] = new List<Move>() { new Moves.Agility() },
			[30] = new List<Move>() { new Moves.Airslash() },
			[35] = new List<Move>() { new Moves.Mist() },
			[40] = new List<Move>() { new Moves.Roost() },
			[45] = new List<Move>() { new Moves.Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Scald(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Aircutter(), new Moves.Aquaring(), new Moves.Gust(), new Moves.Knockoff(), new Moves.Mist(), new Moves.Soak(), new Moves.Twister(), new Moves.Wideguard() };
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