using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arrokuda : Pokemon
	{
		public override string Name => "Arrokuda";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Propellertail() };
		public override Stats BaseStats => new Stats(41, 63, 40, 40, 30, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Aquajet() },
			[6] = new List<Move>() { new Furyattack() },
			[12] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Agility() },
			[24] = new List<Move>() { new Dive() },
			[30] = new List<Move>() { new Laserfocus() },
			[36] = new List<Move>() { new Crunch() },
			[42] = new List<Move>() { new Liquidation() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Brickbreak(), new Closecombat(), new Crunch(), new Dive(), new Drillrun(), new Endure(), new Facade(), new Focusenergy(), new Hiddenpower(), new Icefang(), new Liquidation(), new Poisonjab(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Swift(), new Throatchop(), new Waterfall(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Nightslash(), new Slash(), new Thrash() };
		public override int Weight => 10;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}