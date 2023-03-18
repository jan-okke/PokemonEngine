using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Phione : Pokemon
	{
		public override string Name => "Phione";
		public override List<Ability> AvailableAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(80, 80, 80, 80, 80, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun() },
			[9] = new List<Move>() { new Charm() },
			[16] = new List<Move>() { new Supersonic() },
			[24] = new List<Move>() { new Bubblebeam() },
			[31] = new List<Move>() { new Acidarmor() },
			[39] = new List<Move>() { new Whirlpool() },
			[46] = new List<Move>() { new Waterpulse() },
			[54] = new List<Move>() { new Aquaring() },
			[61] = new List<Move>() { new Dive() },
			[69] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Blizzard(), new Bounce(), new Brine(), new Confide(), new Covet(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Hail(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Knockoff(), new Lastresort(), new Liquidation(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Uproar(), new Uturn(), new Waterfall(), new Waterpulse() };
		public override int Weight => 31;
		public override int ExpYield => 240;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}