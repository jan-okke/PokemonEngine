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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Propellertail() };
		public override Stats BaseStats => new Stats(61, 123, 60, 60, 50, 136);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Throatchop(), new Moves.Peck(), new Moves.Aquajet(), new Moves.Furyattack(), new Moves.Bite() },
			[18] = new List<Move>() { new Moves.Agility() },
			[24] = new List<Move>() { new Moves.Dive() },
			[32] = new List<Move>() { new Moves.Laserfocus() },
			[40] = new List<Move>() { new Moves.Crunch() },
			[48] = new List<Move>() { new Moves.Liquidation() },
			[56] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dive(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Liquidation(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Throatchop(), new Moves.Waterfall(), new Moves.Whirlpool() };
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