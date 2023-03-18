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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Megalauncher() };
		public override Stats BaseStats => new Stats(50, 53, 62, 58, 63, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Splash(), new Moves.Watergun() },
			[5] = new List<Move>() { new Moves.Visegrip() },
			[10] = new List<Move>() { new Moves.Flail() },
			[15] = new List<Move>() { new Moves.Aquajet() },
			[20] = new List<Move>() { new Moves.Smackdown() },
			[25] = new List<Move>() { new Moves.Honeclaws() },
			[30] = new List<Move>() { new Moves.Waterpulse() },
			[35] = new List<Move>() { new Moves.Swordsdance() },
			[40] = new List<Move>() { new Moves.Aurasphere() },
			[45] = new List<Move>() { new Moves.Bounce() },
			[50] = new List<Move>() { new Moves.Muddywater() },
			[55] = new List<Move>() { new Moves.Crabhammer() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Bounce(), new Moves.Dive(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Waterfall() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Bubblebeam(), new Moves.Entrainment() };
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