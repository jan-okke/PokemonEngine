using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zweilous : Pokemon
	{
		public override string Name => "Zweilous";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle() };
		public override Stats BaseStats => new Stats(72, 85, 70, 65, 70, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Doublehit(), new Moves.Focusenergy(), new Moves.Dragonbreath(), new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Roar() },
			[16] = new List<Move>() { new Moves.Assurance() },
			[20] = new List<Move>() { new Moves.Headbutt() },
			[24] = new List<Move>() { new Moves.Workup() },
			[28] = new List<Move>() { new Moves.Slam() },
			[32] = new List<Move>() { new Moves.Crunch() },
			[36] = new List<Move>() { new Moves.Scaryface() },
			[40] = new List<Move>() { new Moves.Dragonpulse() },
			[44] = new List<Move>() { new Moves.Bodyslam() },
			[48] = new List<Move>() { new Moves.Hypervoice() },
			[54] = new List<Move>() { new Moves.Dragonrush() },
			[60] = new List<Move>() { new Moves.Nastyplot() },
			[66] = new List<Move>() { new Moves.Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 500;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}