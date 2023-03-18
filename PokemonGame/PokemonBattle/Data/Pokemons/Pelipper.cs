using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pelipper : Pokemon
	{
		public override string Name => "Pelipper";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Drizzle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(60, 50, 100, 65, 95, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Protect(), new Soak(), new Quickattack(), new Agility(), new Airslash(), new Growl(), new Watergun(), new Tailwind(), new Supersonic() },
			[15] = new List<Move>() { new Wingattack() },
			[20] = new List<Move>() { new Waterpulse() },
			[28] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[34] = new List<Move>() { new Fling() },
			[41] = new List<Move>() { new Mist() },
			[48] = new List<Move>() { new Roost() },
			[55] = new List<Move>() { new Hurricane() },
			[62] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Attract(), new Blizzard(), new Bravebird(), new Brine(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Fling(), new Fly(), new Gigaimpact(), new Gunkshot(), new Hail(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Liquidation(), new Payback(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Roost(), new Round(), new Scald(), new Seedbomb(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Uturn(), new Waterpulse(), new Weatherball(), new Whirlpool() };
		public override int Weight => 280;
		public override int ExpYield => 154;
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