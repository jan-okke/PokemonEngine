using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swablu : Pokemon
	{
		public override string Name => "Swablu";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cloudnine() };
		public override Stats BaseStats => new Stats(45, 40, 60, 40, 75, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Growl() },
			[4] = new List<Move>() { new Disarmingvoice() },
			[8] = new List<Move>() { new Mist() },
			[12] = new List<Move>() { new Furyattack() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Dragonbreath() },
			[24] = new List<Move>() { new Safeguard() },
			[28] = new List<Move>() { new Sing() },
			[32] = new List<Move>() { new Cottonguard() },
			[36] = new List<Move>() { new Takedown() },
			[40] = new List<Move>() { new Moonblast() },
			[44] = new List<Move>() { new Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Bodyslam(), new Dazzlinggleam(), new Doubleteam(), new Dragonpulse(), new Dreameater(), new Dualwingbeat(), new Endure(), new Facade(), new Falseswipe(), new Fly(), new Heatwave(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Outrage(), new Playrough(), new Pluck(), new Powerswap(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roost(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Astonish(), new Dragonrush(), new Featherdance(), new Haze(), new Hypervoice(), new Playrough(), new Powerswap(), new Tailwind() };
		public override int Weight => 12;
		public override int ExpYield => 62;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}