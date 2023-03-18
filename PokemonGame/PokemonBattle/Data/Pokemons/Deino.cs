using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Deino : Pokemon
	{
		public override string Name => "Deino";
		public override List<Ability> AvailableAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(52, 65, 50, 45, 50, 38);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Focusenergy() },
			[4] = new List<Move>() { new Dragonbreath() },
			[8] = new List<Move>() { new Bite() },
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
			[52] = new List<Move>() { new Dragonrush() },
			[56] = new List<Move>() { new Nastyplot() },
			[60] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Crunch(), new Darkpulse(), new Dracometeor(), new Dragonpulse(), new Earthpower(), new Endure(), new Facade(), new Firefang(), new Focusenergy(), new Hiddenpower(), new Hypervoice(), new Icefang(), new Nastyplot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Thunderfang(), new Thunderwave(), new Uproar(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Belch(), new Doublehit(), new Headsmash() };
		public override int Weight => 173;
		public override int ExpYield => 60;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}