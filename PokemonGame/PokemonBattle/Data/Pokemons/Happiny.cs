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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
		public override Stats BaseStats => new Stats(100, 5, 5, 15, 65, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Minimize(), new Moves.Pound(), new Moves.Copycat() },
			[4] = new List<Move>() { new Moves.Defensecurl() },
			[8] = new List<Move>() { new Moves.Sweetkiss() },
			[12] = new List<Move>() { new Moves.Disarmingvoice() },
			[16] = new List<Move>() { new Moves.Covet() },
			[20] = new List<Move>() { new Moves.Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Metronome(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aromatherapy(), new Moves.Counter(), new Moves.Gravity(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Lastresort(), new Moves.Metronome(), new Moves.Present(), new Moves.Seismictoss() };
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