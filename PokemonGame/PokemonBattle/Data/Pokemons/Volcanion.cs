using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Volcanion : Pokemon
	{
		public override string Name => "Volcanion";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(80, 110, 120, 130, 90, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Firespin(), new Watergun() },
			[6] = new List<Move>() { new Leer() },
			[12] = new List<Move>() { new Weatherball() },
			[18] = new List<Move>() { new Flamecharge() },
			[24] = new List<Move>() { new Waterpulse() },
			[30] = new List<Move>() { new Scaryface() },
			[36] = new List<Move>() { new Incinerate() },
			[42] = new List<Move>() { new Stomp() },
			[48] = new List<Move>() { new Scald() },
			[54] = new List<Move>() { new Takedown() },
			[60] = new List<Move>() { new Mist(), new Haze() },
			[66] = new List<Move>() { new Hydropump() },
			[72] = new List<Move>() { new Steameruption() },
			[78] = new List<Move>() { new Flareblitz() },
			[84] = new List<Move>() { new Overheat() },
			[90] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Flashcannon(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Liquidation(), new Mistyterrain(), new Mudshot(), new Overheat(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Sandstorm(), new Scald(), new Scaryface(), new Scorchingsands(), new Selfdestruct(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Thunderfang(), new Weatherball(), new Willowisp() };
		public override int Weight => 1950;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}