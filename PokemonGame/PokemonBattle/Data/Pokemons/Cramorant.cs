using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cramorant : Pokemon
	{
		public override string Name => "Cramorant";
		public override List<Ability> AvailableAbilities => new() {new Gulpmissile() };
		public override Stats BaseStats => new Stats(70, 85, 55, 85, 95, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Belch(), new Peck(), new Stockpile(), new Swallow(), new Spitup() },
			[7] = new List<Move>() { new Watergun() },
			[14] = new List<Move>() { new Furyattack() },
			[21] = new List<Move>() { new Pluck() },
			[28] = new List<Move>() { new Dive() },
			[35] = new List<Move>() { new Drillpeck() },
			[42] = new List<Move>() { new Amnesia() },
			[49] = new List<Move>() { new Thrash() },
			[56] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Amnesia(), new Assurance(), new Attract(), new Blizzard(), new Bravebird(), new Dive(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Gigaimpact(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Superpower(), new Surf(), new Thief(), new Throatchop(), new Uproar(), new Weatherball(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aerialace(), new Aquaring(), new Defog(), new Featherdance(), new Roost() };
		public override int Weight => 180;
		public override int ExpYield => 166;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}