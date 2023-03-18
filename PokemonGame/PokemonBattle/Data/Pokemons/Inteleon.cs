using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Inteleon : Pokemon
	{
		public override string Name => "Inteleon";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(70, 85, 65, 125, 65, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Snipeshot() },
			[1] = new List<Move>() { new Snipeshot(), new Acrobatics(), new Pound(), new Growl(), new Watergun(), new Bind() },
			[12] = new List<Move>() { new Waterpulse() },
			[19] = new List<Move>() { new Tearfullook() },
			[24] = new List<Move>() { new Suckerpunch() },
			[30] = new List<Move>() { new Uturn() },
			[38] = new List<Move>() { new Liquidation() },
			[46] = new List<Move>() { new Soak() },
			[54] = new List<Move>() { new Raindance() },
			[62] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Attract(), new Batonpass(), new Blizzard(), new Bounce(), new Breakingswipe(), new Darkpulse(), new Dive(), new Endure(), new Facade(), new Fling(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Hydrocannon(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Lightscreen(), new Liquidation(), new Metronome(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Scald(), new Scaleshot(), new Shadowball(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swift(), new Swordsdance(), new Uturn(), new Waterfall(), new Waterpledge(), new Weatherball(), new Whirlpool(), new Workup() };
		public override int Weight => 452;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}