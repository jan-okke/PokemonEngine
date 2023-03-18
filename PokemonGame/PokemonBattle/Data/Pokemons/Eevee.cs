using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eevee : Pokemon
	{
		public override string Name => "Eevee";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Adaptability() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Anticipation() };
		public override Stats BaseStats => new Stats(55, 55, 50, 45, 65, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Covet(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Swift() },
			[25] = new List<Move>() { new Bite() },
			[30] = new List<Move>() { new Copycat() },
			[35] = new List<Move>() { new Batonpass() },
			[40] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Charm() },
			[50] = new List<Move>() { new Doubleedge() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bodyslam(), new Charm(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Payday(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Weatherball(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Covet(), new Curse(), new Detect(), new Doublekick(), new Faketears(), new Flail(), new Mudslap(), new Storedpower(), new Tickle(), new Wish(), new Yawn() };
		public override int Weight => 65;
		public override int ExpYield => 65;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}