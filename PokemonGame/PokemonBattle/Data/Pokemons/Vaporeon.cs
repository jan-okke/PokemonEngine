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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
		public override Stats BaseStats => new Stats(130, 65, 60, 110, 95, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Watergun() },
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Covet(), new Moves.Swift(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Sandattack() },
			[10] = new List<Move>() { new Moves.Quickattack() },
			[15] = new List<Move>() { new Moves.Babydolleyes() },
			[20] = new List<Move>() { new Moves.Haze() },
			[25] = new List<Move>() { new Moves.Waterpulse() },
			[30] = new List<Move>() { new Moves.Aurorabeam() },
			[35] = new List<Move>() { new Moves.Aquaring() },
			[40] = new List<Move>() { new Moves.Muddywater() },
			[45] = new List<Move>() { new Moves.Acidarmor() },
			[50] = new List<Move>() { new Moves.Hydropump() },
			[55] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Charm(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flipturn(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Payday(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Workup() };
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