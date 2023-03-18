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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
		public override Stats BaseStats => new Stats(70, 85, 65, 125, 65, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Snipeshot() },
			[1] = new List<Move>() { new Moves.Snipeshot(), new Moves.Acrobatics(), new Moves.Pound(), new Moves.Growl(), new Moves.Watergun(), new Moves.Bind() },
			[12] = new List<Move>() { new Moves.Waterpulse() },
			[19] = new List<Move>() { new Moves.Tearfullook() },
			[24] = new List<Move>() { new Moves.Suckerpunch() },
			[30] = new List<Move>() { new Moves.Uturn() },
			[38] = new List<Move>() { new Moves.Liquidation() },
			[46] = new List<Move>() { new Moves.Soak() },
			[54] = new List<Move>() { new Moves.Raindance() },
			[62] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Breakingswipe(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hydrocannon(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Metronome(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Workup() };
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