using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clauncher : Pokemon
	{
		public override string Name => "Clauncher";
		public override List<Ability> AvailableAbilities => new() {new Megalauncher() };
		public override Stats BaseStats => new Stats(50, 53, 62, 58, 63, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Watergun() },
			[5] = new List<Move>() { new Visegrip() },
			[10] = new List<Move>() { new Flail() },
			[15] = new List<Move>() { new Aquajet() },
			[20] = new List<Move>() { new Smackdown() },
			[25] = new List<Move>() { new Honeclaws() },
			[30] = new List<Move>() { new Waterpulse() },
			[35] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Aurasphere() },
			[45] = new List<Move>() { new Bounce() },
			[50] = new List<Move>() { new Muddywater() },
			[55] = new List<Move>() { new Crabhammer() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Bounce(), new Dive(), new Dragonpulse(), new Endure(), new Facade(), new Flashcannon(), new Flipturn(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Muddywater(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Swordsdance(), new Terrainpulse(), new Uturn(), new Venoshock(), new Waterfall() };
		public override List<Move> EggMoves => new List<Move>() { new Aquatail(), new Bubblebeam(), new Entrainment() };
		public override int Weight => 83;
		public override int ExpYield => 66;
		public override int CatchRate => 225;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}