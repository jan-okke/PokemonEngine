using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Omanyte : Pokemon
	{
		public override string Name => "Omanyte";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(35, 40, 100, 35, 90, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bind(), new Withdraw() },
			[5] = new List<Move>() { new Rollout() },
			[10] = new List<Move>() { new Sandattack() },
			[15] = new List<Move>() { new Watergun() },
			[20] = new List<Move>() { new Leer() },
			[25] = new List<Move>() { new Mudshot() },
			[30] = new List<Move>() { new Ancientpower() },
			[35] = new List<Move>() { new Brine() },
			[41] = new List<Move>() { new Protect() },
			[45] = new List<Move>() { new Rockblast() },
			[50] = new List<Move>() { new Surf() },
			[55] = new List<Move>() { new Shellsmash() },
			[60] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Dive(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Gyroball(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Toxicspikes(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aurorabeam(), new Bite(), new Bubblebeam(), new Haze(), new Knockoff(), new Muddywater(), new Reflecttype(), new Slam(), new Spikes(), new Supersonic(), new Tickle(), new Toxicspikes(), new Whirlpool() };
		public override int Weight => 75;
		public override int ExpYield => 71;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}