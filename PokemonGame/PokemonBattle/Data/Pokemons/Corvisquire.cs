using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Corvisquire : Pokemon
	{
		public override string Name => "Corvisquire";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bigpecks() };
		public override Stats BaseStats => new Stats(68, 67, 55, 43, 55, 77);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Leer(), new Powertrip(), new Honeclaws() },
			[12] = new List<Move>() { new Furyattack() },
			[16] = new List<Move>() { new Pluck() },
			[22] = new List<Move>() { new Taunt() },
			[28] = new List<Move>() { new Scaryface() },
			[34] = new List<Move>() { new Drillpeck() },
			[40] = new List<Move>() { new Swagger() },
			[46] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Dualwingbeat(), new Endure(), new Facade(), new Faketears(), new Fly(), new Focusenergy(), new Hiddenpower(), new Nastyplot(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Uturn(), new Workup() };
		public override int Weight => 160;
		public override int ExpYield => 128;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}