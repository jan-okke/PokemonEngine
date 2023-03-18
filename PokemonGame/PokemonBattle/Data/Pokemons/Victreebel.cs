using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Victreebel : Pokemon
	{
		public override string Name => "Victreebel";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(80, 105, 65, 100, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Leaftornado() },
			[1] = new List<Move>() { new Moves.Leaftornado(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup(), new Moves.Vinewhip(), new Moves.Sleeppowder(), new Moves.Sweetscent(), new Moves.Razorleaf() },
			[32] = new List<Move>() { new Moves.Leafstorm() },
			[44] = new List<Move>() { new Moves.Leafblade() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bind(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Naturepower(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Worryseed() };
		public override int Weight => 155;
		public override int ExpYield => 245;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}