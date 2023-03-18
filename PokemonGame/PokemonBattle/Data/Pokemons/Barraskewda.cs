using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Barraskewda : Pokemon
	{
		public override string Name => "Barraskewda";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Propellertail() };
		public override Stats BaseStats => new Stats(61, 123, 60, 136, 60, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Throatchop(), new Peck(), new Aquajet(), new Furyattack(), new Bite() },
			[18] = new List<Move>() { new Agility() },
			[24] = new List<Move>() { new Dive() },
			[32] = new List<Move>() { new Laserfocus() },
			[40] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Liquidation() },
			[56] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Brickbreak(), new Closecombat(), new Crunch(), new Dive(), new Drillrun(), new Endure(), new Facade(), new Flipturn(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icefang(), new Liquidation(), new Poisonjab(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Scaryface(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swift(), new Throatchop(), new Waterfall(), new Whirlpool() };
		public override int Weight => 300;
		public override int ExpYield => 172;
		public override int CatchRate => 60;
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