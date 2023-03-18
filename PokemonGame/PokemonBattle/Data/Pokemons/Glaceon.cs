using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Glaceon : Pokemon
	{
		public override string Name => "Glaceon";
		public override List<Ability> AvailableAbilities => new() {new Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(65, 60, 110, 65, 130, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Icywind() },
			[1] = new List<Move>() { new Icywind(), new Covet(), new Swift(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Iceshard() },
			[25] = new List<Move>() { new Bite() },
			[30] = new List<Move>() { new Icefang() },
			[35] = new List<Move>() { new Hail() },
			[40] = new List<Move>() { new Freezedry() },
			[45] = new List<Move>() { new Mirrorcoat() },
			[50] = new List<Move>() { new Blizzard() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Batonpass(), new Blizzard(), new Bodyslam(), new Charm(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Focusenergy(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Irontail(), new Payday(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Tripleaxel(), new Waterpulse(), new Weatherball(), new Workup() };
		public override int Weight => 259;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}