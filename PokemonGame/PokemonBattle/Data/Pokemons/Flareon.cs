using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Flareon : Pokemon
	{
		public override string Name => "Flareon";
		public override List<Ability> AvailableAbilities => new() {new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Guts() };
		public override Stats BaseStats => new Stats(65, 130, 60, 65, 95, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Ember() },
			[1] = new List<Move>() { new Ember(), new Covet(), new Swift(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Smog() },
			[25] = new List<Move>() { new Bite() },
			[30] = new List<Move>() { new Firefang() },
			[35] = new List<Move>() { new Firespin() },
			[40] = new List<Move>() { new Lavaplume() },
			[45] = new List<Move>() { new Scaryface() },
			[50] = new List<Move>() { new Flareblitz() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bodyslam(), new Burningjealousy(), new Charm(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flareblitz(), new Focusenergy(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Mysticalfire(), new Overheat(), new Payday(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Round(), new Scaryface(), new Scorchingsands(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Weatherball(), new Willowisp(), new Workup() };
		public override int Weight => 250;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}