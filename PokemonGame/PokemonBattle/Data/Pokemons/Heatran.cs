using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heatran : Pokemon
	{
		public override string Name => "Heatran";
		public override List<Ability> AvailableAbilities => new() {new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flamebody() };
		public override Stats BaseStats => new Stats(91, 90, 106, 130, 106, 77);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Firespin(), new Leer() },
			[6] = new List<Move>() { new Metalclaw() },
			[12] = new List<Move>() { new Ancientpower() },
			[18] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Ironhead() },
			[36] = new List<Move>() { new Crunch() },
			[42] = new List<Move>() { new Lavaplume() },
			[48] = new List<Move>() { new Metalsound() },
			[54] = new List<Move>() { new Earthpower() },
			[60] = new List<Move>() { new Heatwave() },
			[66] = new List<Move>() { new Stoneedge() },
			[72] = new List<Move>() { new Magmastorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Burningjealousy(), new Crunch(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flashcannon(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Overheat(), new Payback(), new Protect(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Scorchingsands(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Torment(), new Uproar(), new Willowisp() };
		public override int Weight => 4300;
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