using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tranquill : Pokemon
	{
		public override string Name => "Tranquill";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rivalry() };
		public override Stats BaseStats => new Stats(62, 77, 62, 65, 50, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Growl(), new Leer(), new Quickattack() },
			[12] = new List<Move>() { new Taunt() },
			[16] = new List<Move>() { new Aircutter() },
			[20] = new List<Move>() { new Swagger() },
			[26] = new List<Move>() { new Featherdance() },
			[34] = new List<Move>() { new Detect() },
			[38] = new List<Move>() { new Airslash() },
			[44] = new List<Move>() { new Roost() },
			[50] = new List<Move>() { new Tailwind() },
			[56] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Attract(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Focusenergy(), new Heatwave(), new Hiddenpower(), new Protect(), new Raindance(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 150;
		public override int ExpYield => 125;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}