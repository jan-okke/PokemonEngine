using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Unfezant : Pokemon
	{
		public override string Name => "Unfezant";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rivalry() };
		public override Stats BaseStats => new Stats(80, 115, 80, 93, 65, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Growl(), new Leer(), new Quickattack() },
			[12] = new List<Move>() { new Taunt() },
			[16] = new List<Move>() { new Aircutter() },
			[20] = new List<Move>() { new Swagger() },
			[26] = new List<Move>() { new Featherdance() },
			[36] = new List<Move>() { new Detect() },
			[42] = new List<Move>() { new Airslash() },
			[50] = new List<Move>() { new Roost() },
			[58] = new List<Move>() { new Tailwind() },
			[66] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Attract(), new Bravebird(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Focusenergy(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Protect(), new Raindance(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 290;
		public override int ExpYield => 244;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}