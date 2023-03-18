using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drifloon : Pokemon
	{
		public override string Name => "Drifloon";
		public override List<Ability> AvailableAbilities => new() {new Aftermath(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flareboost() };
		public override Stats BaseStats => new Stats(90, 50, 34, 70, 60, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Minimize(), new Astonish() },
			[4] = new List<Move>() { new Gust() },
			[8] = new List<Move>() { new Focusenergy() },
			[12] = new List<Move>() { new Payback() },
			[16] = new List<Move>() { new Hex() },
			[20] = new List<Move>() { new Shadowball() },
			[24] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[29] = new List<Move>() { new Selfdestruct() },
			[32] = new List<Move>() { new Destinybond() },
			[36] = new List<Move>() { new Batonpass() },
			[40] = new List<Move>() { new Tailwind() },
			[44] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Amnesia(), new Attract(), new Batonpass(), new Bodyslam(), new Brutalswing(), new Calmmind(), new Chargebeam(), new Cut(), new Defog(), new Doubleteam(), new Dreameater(), new Endure(), new Explosion(), new Facade(), new Flash(), new Focusenergy(), new Gyroball(), new Hex(), new Hiddenpower(), new Icywind(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Round(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Weatherball(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Clearsmog(), new Destinybond(), new Disable(), new Haze(), new Hypnosis(), new Memento(), new Tailwind(), new Weatherball() };
		public override int Weight => 12;
		public override int ExpYield => 70;
		public override int CatchRate => 125;
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