using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Finneon : Pokemon
	{
		public override string Name => "Finneon";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Stormdrain() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterveil() };
		public override Stats BaseStats => new Stats(49, 49, 56, 49, 61, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound() },
			[6] = new List<Move>() { new Moves.Watergun() },
			[10] = new List<Move>() { new Moves.Attract() },
			[13] = new List<Move>() { new Moves.Raindance() },
			[17] = new List<Move>() { new Moves.Gust() },
			[22] = new List<Move>() { new Moves.Waterpulse() },
			[26] = new List<Move>() { new Moves.Flail() },
			[29] = new List<Move>() { new Moves.Safeguard() },
			[33] = new List<Move>() { new Moves.Aquaring() },
			[38] = new List<Move>() { new Moves.Whirlpool() },
			[42] = new List<Move>() { new Moves.Uturn() },
			[45] = new List<Move>() { new Moves.Bounce() },
			[49] = new List<Move>() { new Moves.Tailwind() },
			[54] = new List<Move>() { new Moves.Soak() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Confide(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Aquatail(), new Moves.Aurorabeam(), new Moves.Charm(), new Moves.Confuseray(), new Moves.Flail(), new Moves.Psybeam(), new Moves.Splash(), new Moves.Sweetkiss(), new Moves.Tickle() };
		public override int Weight => 70;
		public override int ExpYield => 66;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}