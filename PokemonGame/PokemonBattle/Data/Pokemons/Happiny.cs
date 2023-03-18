using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Happiny : Pokemon
	{
		public override string Name => "Happiny";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Friendguard() };
		public override Stats BaseStats => new Stats(100, 5, 5, 30, 15, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Minimize(), new Pound(), new Copycat() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Sweetkiss() },
			[12] = new List<Move>() { new Disarmingvoice() },
			[16] = new List<Move>() { new Covet() },
			[20] = new List<Move>() { new Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Lightscreen(), new Metronome(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderwave(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Aromatherapy(), new Counter(), new Gravity(), new Healbell(), new Helpinghand(), new Lastresort(), new Metronome(), new Present(), new Seismictoss() };
		public override int Weight => 244;
		public override int ExpYield => 110;
		public override int CatchRate => 130;
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