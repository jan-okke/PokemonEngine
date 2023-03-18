using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Carnivine : Pokemon
	{
		public override string Name => "Carnivine";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(74, 100, 72, 90, 72, 46);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Bind(), new Moves.Growth() },
			[7] = new List<Move>() { new Moves.Bite() },
			[11] = new List<Move>() { new Moves.Vinewhip() },
			[17] = new List<Move>() { new Moves.Sweetscent() },
			[21] = new List<Move>() { new Moves.Ingrain() },
			[27] = new List<Move>() { new Moves.Grassknot() },
			[31] = new List<Move>() { new Moves.Leaftornado() },
			[37] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
			[41] = new List<Move>() { new Moves.Crunch() },
			[47] = new List<Move>() { new Moves.Seedbomb() },
			[50] = new List<Move>() { new Moves.Powerwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bind(), new Moves.Bugbite(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Leechseed(), new Moves.Magicalleaf(), new Moves.Ragepowder(), new Moves.Razorleaf(), new Moves.Slam(), new Moves.Sleeppowder(), new Moves.Stunspore(), new Moves.Synthesis(), new Moves.Worryseed() };
		public override int Weight => 270;
		public override int ExpYield => 159;
		public override int CatchRate => 200;
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