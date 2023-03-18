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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Aftermath(), new Abilities.Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flareboost() };
		public override Stats BaseStats => new Stats(150, 80, 44, 90, 54, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Phantomforce() },
			[1] = new List<Move>() { new Moves.Phantomforce(), new Moves.Strengthsap(), new Moves.Minimize(), new Moves.Astonish(), new Moves.Gust(), new Moves.Focusenergy() },
			[12] = new List<Move>() { new Moves.Payback() },
			[16] = new List<Move>() { new Moves.Hex() },
			[20] = new List<Move>() { new Moves.Shadowball() },
			[24] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
			[31] = new List<Move>() { new Moves.Selfdestruct() },
			[36] = new List<Move>() { new Moves.Destinybond() },
			[42] = new List<Move>() { new Moves.Batonpass() },
			[48] = new List<Move>() { new Moves.Tailwind() },
			[54] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Weatherball(), new Moves.Willowisp() };
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