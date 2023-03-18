using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Corviknight : Pokemon
	{
		public override string Name => "Corviknight";
		public override List<Ability> AvailableAbilities => new() {new Pressure(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Mirrorarmor() };
		public override Stats BaseStats => new Stats(98, 87, 105, 53, 85, 67);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Steelwing() },
			[1] = new List<Move>() { new Steelwing(), new Irondefense(), new Metalsound(), new Peck(), new Leer(), new Powertrip(), new Honeclaws() },
			[12] = new List<Move>() { new Furyattack() },
			[16] = new List<Move>() { new Pluck() },
			[22] = new List<Move>() { new Taunt() },
			[28] = new List<Move>() { new Scaryface() },
			[34] = new List<Move>() { new Drillpeck() },
			[42] = new List<Move>() { new Swagger() },
			[50] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Assurance(), new Attract(), new Bodypress(), new Bodyslam(), new Bravebird(), new Bulkup(), new Dualwingbeat(), new Endure(), new Facade(), new Faketears(), new Flashcannon(), new Fly(), new Focusenergy(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lightscreen(), new Nastyplot(), new Payback(), new Protect(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelwing(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Uturn(), new Workup() };
		public override int Weight => 750;
		public override int ExpYield => 248;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}