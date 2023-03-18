using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vaporeon : Pokemon
	{
		public override string Name => "Vaporeon";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(130, 65, 60, 65, 110, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Watergun() },
			[1] = new List<Move>() { new Watergun(), new Covet(), new Swift(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Haze() },
			[25] = new List<Move>() { new Waterpulse() },
			[30] = new List<Move>() { new Aurorabeam() },
			[35] = new List<Move>() { new Aquaring() },
			[40] = new List<Move>() { new Muddywater() },
			[45] = new List<Move>() { new Acidarmor() },
			[50] = new List<Move>() { new Hydropump() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Brine(), new Charm(), new Dig(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Flipturn(), new Focusenergy(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Liquidation(), new Muddywater(), new Payday(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Round(), new Scald(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Workup() };
		public override int Weight => 290;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
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