using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swellow : Pokemon
	{
		public override string Name => "Swellow";
		public override List<Ability> AvailableAbilities => new() {new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(60, 85, 60, 75, 50, 125);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bravebird(), new Airslash(), new Pluck(), new Peck(), new Growl(), new Focusenergy(), new Quickattack() },
			[5] = new List<Move>() { new Focusenergy() },
			[9] = new List<Move>() { new Quickattack() },
			[13] = new List<Move>() { new Wingattack() },
			[17] = new List<Move>() { new Doubleteam() },
			[21] = new List<Move>() { new Aerialace() },
			[27] = new List<Move>() { new Quickguard() },
			[33] = new List<Move>() { new Agility() },
			[39] = new List<Move>() { new Airslash() },
			[45] = new List<Move>() { new Endeavor() },
			[51] = new List<Move>() { new Bravebird() },
			[57] = new List<Move>() { new Reversal() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Workup() };
		public override int Weight => 198;
		public override int ExpYield => 159;
		public override int CatchRate => 45;
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