using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Greedent : Pokemon
	{
		public override string Name => "Greedent";
		public override List<Ability> AvailableAbilities => new() {new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(120, 95, 95, 55, 75, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Covet() },
			[1] = new List<Move>() { new Covet(), new Tackle(), new Tailwhip(), new Bite(), new Stuffcheeks() },
			[15] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[20] = new List<Move>() { new Bodyslam() },
			[27] = new List<Move>() { new Rest() },
			[34] = new List<Move>() { new Counter() },
			[41] = new List<Move>() { new Bulletseed() },
			[48] = new List<Move>() { new Superfang() },
			[55] = new List<Move>() { new Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Bodypress(), new Bodyslam(), new Brutalswing(), new Bulletseed(), new Crunch(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Fling(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icefang(), new Irontail(), new Mudshot(), new Payback(), new Protect(), new Psychicfangs(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Swordsdance(), new Tailslap(), new Thief(), new Thunderfang(), new Uproar(), new Wildcharge() };
		public override int Weight => 60;
		public override int ExpYield => 161;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}