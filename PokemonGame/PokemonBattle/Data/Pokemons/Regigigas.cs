using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regigigas : Pokemon
	{
		public override string Name => "Regigigas";
		public override List<Ability> AvailableAbilities => new() {new Slowstart() };
		public override Stats BaseStats => new Stats(110, 160, 110, 80, 110, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Confuseray() },
			[6] = new List<Move>() { new Payback() },
			[12] = new List<Move>() { new Revenge() },
			[18] = new List<Move>() { new Stomp() },
			[24] = new List<Move>() { new Protect() },
			[30] = new List<Move>() { new Knockoff() },
			[36] = new List<Move>() { new Megapunch() },
			[42] = new List<Move>() { new Bodypress() },
			[48] = new List<Move>() { new Wideguard() },
			[54] = new List<Move>() { new Zenheadbutt() },
			[60] = new List<Move>() { new Heavyslam() },
			[66] = new List<Move>() { new Hammerarm() },
			[72] = new List<Move>() { new Gigaimpact() },
			[78] = new List<Move>() { new Crushgrip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Avalanche(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Darkestlariat(), new Doubleteam(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icepunch(), new Icywind(), new Ironhead(), new Megakick(), new Megapunch(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Terrainpulse(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Zenheadbutt() };
		public override int Weight => 4200;
		public override int ExpYield => 335;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}