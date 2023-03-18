using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Weepinbell : Pokemon
	{
		public override string Name => "Weepinbell";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(65, 90, 50, 55, 85, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Vinewhip(), new Growth(), new Wrap() },
			[7] = new List<Move>() { new Growth() },
			[11] = new List<Move>() { new Wrap() },
			[13] = new List<Move>() { new Sleeppowder() },
			[15] = new List<Move>() { new Poisonpowder() },
			[17] = new List<Move>() { new Stunspore() },
			[24] = new List<Move>() { new Acid() },
			[29] = new List<Move>() { new Knockoff() },
			[32] = new List<Move>() { new Sweetscent() },
			[39] = new List<Move>() { new Gastroacid() },
			[44] = new List<Move>() { new Razorleaf() },
			[47] = new List<Move>() { new Poisonjab() },
			[54] = new List<Move>() { new Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bind(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gastroacid(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Infestation(), new Knockoff(), new Naturepower(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Venoshock(), new Worryseed() };
		public override int Weight => 64;
		public override int ExpYield => 137;
		public override int CatchRate => 120;
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