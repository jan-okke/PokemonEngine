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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icebody() };
		public override Stats BaseStats => new Stats(65, 60, 110, 130, 95, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Icywind() },
			[1] = new List<Move>() { new Moves.Icywind(), new Moves.Covet(), new Moves.Swift(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Sandattack() },
			[10] = new List<Move>() { new Moves.Quickattack() },
			[15] = new List<Move>() { new Moves.Babydolleyes() },
			[20] = new List<Move>() { new Moves.Iceshard() },
			[25] = new List<Move>() { new Moves.Bite() },
			[30] = new List<Move>() { new Moves.Icefang() },
			[35] = new List<Move>() { new Moves.Hail() },
			[40] = new List<Move>() { new Moves.Freezedry() },
			[45] = new List<Move>() { new Moves.Mirrorcoat() },
			[50] = new List<Move>() { new Moves.Blizzard() },
			[55] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Payday(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tripleaxel(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Workup() };
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