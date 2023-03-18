using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Horsea : Pokemon
	{
		public override string Name => "Horsea";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(30, 40, 70, 60, 70, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Leer() },
			[5] = new List<Move>() { new Smokescreen() },
			[10] = new List<Move>() { new Twister() },
			[15] = new List<Move>() { new Focusenergy() },
			[20] = new List<Move>() { new Dragonbreath() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Agility() },
			[35] = new List<Move>() { new Laserfocus() },
			[40] = new List<Move>() { new Dragonpulse() },
			[45] = new List<Move>() { new Hydropump() },
			[50] = new List<Move>() { new Dragondance() },
			[55] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Dive(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Flashcannon(), new Flipturn(), new Focusenergy(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Liquidation(), new Muddywater(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aurorabeam(), new Clearsmog(), new Disable(), new Dragonbreath(), new Flail(), new Muddywater(), new Octazooka(), new Outrage(), new Splash() };
		public override int Weight => 80;
		public override int ExpYield => 59;
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