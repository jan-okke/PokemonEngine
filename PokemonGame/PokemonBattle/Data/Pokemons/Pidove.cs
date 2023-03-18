using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pidove : Pokemon
	{
		public override string Name => "Pidove";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Bigpecks(), new Abilities.Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rivalry() };
		public override Stats BaseStats => new Stats(50, 55, 50, 36, 30, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Gust(), new Moves.Growl() },
			[4] = new List<Move>() { new Moves.Leer() },
			[8] = new List<Move>() { new Moves.Quickattack() },
			[12] = new List<Move>() { new Moves.Taunt() },
			[16] = new List<Move>() { new Moves.Aircutter() },
			[20] = new List<Move>() { new Moves.Swagger() },
			[24] = new List<Move>() { new Moves.Featherdance() },
			[28] = new List<Move>() { new Moves.Detect() },
			[32] = new List<Move>() { new Moves.Airslash() },
			[36] = new List<Move>() { new Moves.Roost() },
			[40] = new List<Move>() { new Moves.Tailwind() },
			[44] = new List<Move>() { new Moves.Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defog(), new Moves.Hypnosis(), new Moves.Morningsun(), new Moves.Nightslash(), new Moves.Wish() };
		public override int Weight => 21;
		public override int ExpYield => 53;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}