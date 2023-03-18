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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Drizzle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
		public override Stats BaseStats => new Stats(60, 50, 100, 95, 70, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Protect(), new Moves.Soak(), new Moves.Quickattack(), new Moves.Agility(), new Moves.Airslash(), new Moves.Growl(), new Moves.Watergun(), new Moves.Tailwind(), new Moves.Supersonic() },
			[15] = new List<Move>() { new Moves.Wingattack() },
			[20] = new List<Move>() { new Moves.Waterpulse() },
			[28] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
			[34] = new List<Move>() { new Moves.Fling() },
			[41] = new List<Move>() { new Moves.Mist() },
			[48] = new List<Move>() { new Moves.Roost() },
			[55] = new List<Move>() { new Moves.Hurricane() },
			[62] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bravebird(), new Moves.Brine(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Scald(), new Moves.Seedbomb(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool() };
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