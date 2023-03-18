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
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(74, 100, 72, 46, 90, 72);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bind(), new Growth() },
			[7] = new List<Move>() { new Bite() },
			[11] = new List<Move>() { new Vinewhip() },
			[17] = new List<Move>() { new Sweetscent() },
			[21] = new List<Move>() { new Ingrain() },
			[27] = new List<Move>() { new Grassknot() },
			[31] = new List<Move>() { new Leaftornado() },
			[37] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[41] = new List<Move>() { new Crunch() },
			[47] = new List<Move>() { new Seedbomb() },
			[50] = new List<Move>() { new Powerwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bind(), new Bugbite(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Frustration(), new Gastroacid(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Knockoff(), new Naturepower(), new Payback(), new Protect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Throatchop(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Leechseed(), new Magicalleaf(), new Ragepowder(), new Razorleaf(), new Slam(), new Sleeppowder(), new Stunspore(), new Synthesis(), new Worryseed() };
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