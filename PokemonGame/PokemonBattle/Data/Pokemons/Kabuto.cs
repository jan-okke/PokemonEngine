using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kabuto : Pokemon
	{
		public override string Name => "Kabuto";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(30, 80, 90, 55, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Harden() },
			[5] = new List<Move>() { new Scratch() },
			[10] = new List<Move>() { new Sandattack() },
			[15] = new List<Move>() { new Aquajet() },
			[20] = new List<Move>() { new Leer() },
			[25] = new List<Move>() { new Mudshot() },
			[30] = new List<Move>() { new Ancientpower() },
			[35] = new List<Move>() { new Brine() },
			[41] = new List<Move>() { new Protect() },
			[45] = new List<Move>() { new Leechlife() },
			[50] = new List<Move>() { new Liquidation() },
			[55] = new List<Move>() { new Metalsound() },
			[60] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Dig(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Gigadrain(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Leechlife(), new Liquidation(), new Meteorbeam(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Screech(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aurorabeam(), new Bubblebeam(), new Confuseray(), new Flail(), new Icywind(), new Knockoff(), new Megadrain(), new Mudshot(), new Rapidspin(), new Screech(), new Takedown() };
		public override int Weight => 115;
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