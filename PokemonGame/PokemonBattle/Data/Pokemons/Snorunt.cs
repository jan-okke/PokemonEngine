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
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(50, 50, 50, 50, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Astonish() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Doubleteam() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Protect() },
			[25] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Frostbreath() },
			[35] = new List<Move>() { new Bite() },
			[40] = new List<Move>() { new Icefang() },
			[45] = new List<Move>() { new Hail() },
			[50] = new List<Move>() { new Headbutt() },
			[55] = new List<Move>() { new Crunch() },
			[60] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Crunch(), new Doubleteam(), new Endure(), new Facade(), new Faketears(), new Flash(), new Hail(), new Hex(), new Hiddenpower(), new Icebeam(), new Icefang(), new Icywind(), new Lightscreen(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Sleeptalk(), new Snore(), new Spikes(), new Substitute(), new Swagger(), new Waterpulse(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Disable(), new Faketears(), new Hex(), new Iciclecrash(), new Rollout(), new Spikes(), new Switcheroo(), new Weatherball() };
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