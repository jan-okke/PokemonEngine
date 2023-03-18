using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jolteon : Pokemon
	{
		public override string Name => "Jolteon";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Quickfeet() };
		public override Stats BaseStats => new Stats(65, 65, 60, 110, 95, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thundershock() },
			[1] = new List<Move>() { new Thundershock(), new Covet(), new Swift(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Thunderwave() },
			[25] = new List<Move>() { new Doublekick() },
			[30] = new List<Move>() { new Thunderfang() },
			[35] = new List<Move>() { new Pinmissile() },
			[40] = new List<Move>() { new Discharge() },
			[45] = new List<Move>() { new Agility() },
			[50] = new List<Move>() { new Thunder() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Batonpass(), new Bodyslam(), new Chargebeam(), new Charm(), new Dig(), new Doubleteam(), new Electroball(), new Endure(), new Facade(), new Faketears(), new Flash(), new Focusenergy(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lightscreen(), new Payday(), new Pinmissile(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Risingvoltage(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Voltswitch(), new Weatherball(), new Wildcharge(), new Workup() };
		public override int Weight => 245;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
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