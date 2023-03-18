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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Guts() };
		public override Stats BaseStats => new Stats(65, 130, 60, 95, 110, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Ember() },
			[1] = new List<Move>() { new Moves.Ember(), new Moves.Covet(), new Moves.Swift(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Sandattack() },
			[10] = new List<Move>() { new Moves.Quickattack() },
			[15] = new List<Move>() { new Moves.Babydolleyes() },
			[20] = new List<Move>() { new Moves.Smog() },
			[25] = new List<Move>() { new Moves.Bite() },
			[30] = new List<Move>() { new Moves.Firefang() },
			[35] = new List<Move>() { new Moves.Firespin() },
			[40] = new List<Move>() { new Moves.Lavaplume() },
			[45] = new List<Move>() { new Moves.Scaryface() },
			[50] = new List<Move>() { new Moves.Flareblitz() },
			[55] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Burningjealousy(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payday(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Workup() };
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