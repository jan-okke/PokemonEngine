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
		public override List<Ability> AvailableAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(72, 85, 70, 65, 70, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Doublehit(), new Focusenergy(), new Dragonbreath(), new Bite() },
			[12] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Workup() },
			[28] = new List<Move>() { new Slam() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Scaryface() },
			[40] = new List<Move>() { new Dragonpulse() },
			[44] = new List<Move>() { new Bodyslam() },
			[48] = new List<Move>() { new Hypervoice() },
			[54] = new List<Move>() { new Dragonrush() },
			[60] = new List<Move>() { new Nastyplot() },
			[66] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Crunch(), new Darkpulse(), new Dracometeor(), new Dragonpulse(), new Earthpower(), new Endure(), new Facade(), new Firefang(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icefang(), new Nastyplot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Thunderfang(), new Thunderwave(), new Uproar(), new Workup(), new Zenheadbutt() };
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