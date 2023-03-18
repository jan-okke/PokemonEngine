using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kingdra : Pokemon
	{
		public override string Name => "Kingdra";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(75, 95, 95, 85, 95, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Whirlpool(), new Yawn(), new Watergun(), new Leer(), new Smokescreen(), new Twister() },
			[15] = new List<Move>() { new Focusenergy() },
			[20] = new List<Move>() { new Dragonbreath() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Agility() },
			[37] = new List<Move>() { new Laserfocus() },
			[44] = new List<Move>() { new Dragonpulse() },
			[51] = new List<Move>() { new Hydropump() },
			[58] = new List<Move>() { new Dragondance() },
			[65] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Breakingswipe(), new Brine(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Flashcannon(), new Flipturn(), new Focusenergy(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Ironhead(), new Liquidation(), new Muddywater(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 1520;
		public override int ExpYield => 270;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}