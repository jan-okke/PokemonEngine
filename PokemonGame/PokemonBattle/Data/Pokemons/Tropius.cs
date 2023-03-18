using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tropius : Pokemon
	{
		public override string Name => "Tropius";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Solarpower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Harvest() };
		public override Stats BaseStats => new Stats(99, 68, 83, 51, 72, 87);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leafstorm(), new Leer(), new Gust(), new Growth(), new Razorleaf() },
			[6] = new List<Move>() { new Sweetscent() },
			[10] = new List<Move>() { new Stomp() },
			[16] = new List<Move>() { new Magicalleaf() },
			[21] = new List<Move>() { new Whirlwind() },
			[26] = new List<Move>() { new Leaftornado() },
			[30] = new List<Move>() { new Dragondance() },
			[36] = new List<Move>() { new Airslash() },
			[41] = new List<Move>() { new Bodyslam() },
			[46] = new List<Move>() { new Dragonhammer() },
			[50] = new List<Move>() { new Synthesis() },
			[56] = new List<Move>() { new Solarbeam() },
			[61] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brutalswing(), new Bulldoze(), new Bulletseed(), new Confide(), new Cut(), new Defog(), new Doubleteam(), new Dragonpulse(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fly(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Naturepower(), new Outrage(), new Protect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Tailwind(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Dragondance(), new Dragonhammer(), new Headbutt(), new Leafblade(), new Leafstorm(), new Leechseed(), new Naturepower(), new Slam(), new Synthesis() };
		public override int Weight => 1000;
		public override int ExpYield => 161;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}