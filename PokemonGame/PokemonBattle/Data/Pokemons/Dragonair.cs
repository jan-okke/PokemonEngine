using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dragonair : Pokemon
	{
		public override string Name => "Dragonair";
		public override List<Ability> AvailableAbilities => new() {new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Marvelscale() };
		public override Stats BaseStats => new Stats(61, 84, 65, 70, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Leer(), new Twister(), new Thunderwave() },
			[15] = new List<Move>() { new Dragontail() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Slam() },
			[33] = new List<Move>() { new Aquatail() },
			[39] = new List<Move>() { new Dragonrush() },
			[46] = new List<Move>() { new Safeguard() },
			[53] = new List<Move>() { new Raindance() },
			[60] = new List<Move>() { new Dragondance() },
			[67] = new List<Move>() { new Outrage() },
			[74] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blizzard(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Doubleteam(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Lightscreen(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scaleshot(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 165;
		public override int ExpYield => 147;
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