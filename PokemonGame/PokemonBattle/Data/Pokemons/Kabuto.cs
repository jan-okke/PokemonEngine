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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
		public override Stats BaseStats => new Stats(30, 80, 90, 55, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Harden() },
			[5] = new List<Move>() { new Moves.Scratch() },
			[10] = new List<Move>() { new Moves.Sandattack() },
			[15] = new List<Move>() { new Moves.Aquajet() },
			[20] = new List<Move>() { new Moves.Leer() },
			[25] = new List<Move>() { new Moves.Mudshot() },
			[30] = new List<Move>() { new Moves.Ancientpower() },
			[35] = new List<Move>() { new Moves.Brine() },
			[41] = new List<Move>() { new Moves.Protect() },
			[45] = new List<Move>() { new Moves.Leechlife() },
			[50] = new List<Move>() { new Moves.Liquidation() },
			[55] = new List<Move>() { new Moves.Metalsound() },
			[60] = new List<Move>() { new Moves.Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aurorabeam(), new Moves.Bubblebeam(), new Moves.Confuseray(), new Moves.Flail(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Megadrain(), new Moves.Mudshot(), new Moves.Rapidspin(), new Moves.Screech(), new Moves.Takedown() };
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