using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drifblim : Pokemon
	{
		public override string Name => "Drifblim";
		public override List<Ability> AvailableAbilities => new() {new Aftermath(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flareboost() };
		public override Stats BaseStats => new Stats(150, 80, 44, 90, 54, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Phantomforce() },
			[1] = new List<Move>() { new Phantomforce(), new Strengthsap(), new Minimize(), new Astonish(), new Gust(), new Focusenergy() },
			[12] = new List<Move>() { new Payback() },
			[16] = new List<Move>() { new Hex() },
			[20] = new List<Move>() { new Shadowball() },
			[24] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[31] = new List<Move>() { new Selfdestruct() },
			[36] = new List<Move>() { new Destinybond() },
			[42] = new List<Move>() { new Batonpass() },
			[48] = new List<Move>() { new Tailwind() },
			[54] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Amnesia(), new Attract(), new Batonpass(), new Bodyslam(), new Brutalswing(), new Calmmind(), new Chargebeam(), new Cut(), new Defog(), new Doubleteam(), new Dreameater(), new Endure(), new Explosion(), new Facade(), new Flash(), new Fly(), new Focusenergy(), new Gigaimpact(), new Gyroball(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icywind(), new Imprison(), new Payback(), new Phantomforce(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Round(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Weatherball(), new Willowisp() };
		public override int Weight => 150;
		public override int ExpYield => 174;
		public override int CatchRate => 60;
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