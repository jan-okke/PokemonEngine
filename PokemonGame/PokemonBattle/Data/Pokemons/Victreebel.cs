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
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(80, 105, 65, 100, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Leaftornado() },
			[1] = new List<Move>() { new Leaftornado(), new Stockpile(), new Swallow(), new Spitup(), new Vinewhip(), new Sleeppowder(), new Sweetscent(), new Razorleaf() },
			[32] = new List<Move>() { new Leafstorm() },
			[44] = new List<Move>() { new Leafblade() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bind(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gastroacid(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Knockoff(), new Naturepower(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Venoshock(), new Worryseed() };
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