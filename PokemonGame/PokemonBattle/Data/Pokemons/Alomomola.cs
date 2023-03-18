using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Alomomola : Pokemon
	{
		public override string Name => "Alomomola";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(165, 75, 80, 40, 45, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Playnice(), new Hydropump(), new Wideguard(), new Healingwish(), new Helpinghand(), new Pound(), new Watersport() },
			[5] = new List<Move>() { new Aquaring() },
			[9] = new List<Move>() { new Aquajet() },
			[13] = new List<Move>() { new Doubleslap() },
			[17] = new List<Move>() { new Healpulse() },
			[21] = new List<Move>() { new Protect() },
			[25] = new List<Move>() { new Waterpulse() },
			[29] = new List<Move>() { new Wakeupslap() },
			[33] = new List<Move>() { new Soak() },
			[37] = new List<Move>() { new Wish() },
			[41] = new List<Move>() { new Brine() },
			[45] = new List<Move>() { new Safeguard() },
			[49] = new List<Move>() { new Whirlpool() },
			[53] = new List<Move>() { new Helpinghand() },
			[57] = new List<Move>() { new Healingwish() },
			[61] = new List<Move>() { new Wideguard() },
			[65] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bounce(), new Calmmind(), new Confide(), new Dive(), new Doubleteam(), new Facade(), new Frustration(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Knockoff(), new Lightscreen(), new Liquidation(), new Magiccoat(), new Painsplit(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Toxic(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Endure(), new Mirrorcoat(), new Mist(), new Painsplit(), new Refresh(), new Tickle() };
		public override int Weight => 316;
		public override int ExpYield => 165;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}