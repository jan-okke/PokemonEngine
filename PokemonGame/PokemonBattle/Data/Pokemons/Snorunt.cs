using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Snorunt : Pokemon
	{
		public override string Name => "Snorunt";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
		public override Stats BaseStats => new Stats(50, 50, 50, 50, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Astonish() },
			[5] = new List<Move>() { new Moves.Leer() },
			[10] = new List<Move>() { new Moves.Doubleteam() },
			[15] = new List<Move>() { new Moves.Iceshard() },
			[20] = new List<Move>() { new Moves.Protect() },
			[25] = new List<Move>() { new Moves.Icywind() },
			[30] = new List<Move>() { new Moves.Frostbreath() },
			[35] = new List<Move>() { new Moves.Bite() },
			[40] = new List<Move>() { new Moves.Icefang() },
			[45] = new List<Move>() { new Moves.Hail() },
			[50] = new List<Move>() { new Moves.Headbutt() },
			[55] = new List<Move>() { new Moves.Crunch() },
			[60] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Waterpulse(), new Moves.Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Disable(), new Moves.Faketears(), new Moves.Hex(), new Moves.Iciclecrash(), new Moves.Rollout(), new Moves.Spikes(), new Moves.Switcheroo(), new Moves.Weatherball() };
		public override int Weight => 168;
		public override int ExpYield => 60;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}