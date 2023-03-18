using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Manaphy : Pokemon
	{
		public override string Name => "Manaphy";
		public override List<Ability> AvailableAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tailglow(), new Watergun() },
			[9] = new List<Move>() { new Charm() },
			[16] = new List<Move>() { new Supersonic() },
			[24] = new List<Move>() { new Bubblebeam() },
			[31] = new List<Move>() { new Acidarmor() },
			[39] = new List<Move>() { new Whirlpool() },
			[46] = new List<Move>() { new Waterpulse() },
			[54] = new List<Move>() { new Aquaring() },
			[61] = new List<Move>() { new Dive() },
			[69] = new List<Move>() { new Raindance() },
			[76] = new List<Move>() { new Heartswap() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Blizzard(), new Bounce(), new Brine(), new Calmmind(), new Confide(), new Covet(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Frustration(), new Gigaimpact(), new Grassknot(), new Hail(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Knockoff(), new Lastresort(), new Lightscreen(), new Liquidation(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Uproar(), new Uturn(), new Waterfall(), new Waterpulse() };
		public override int Weight => 14;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}