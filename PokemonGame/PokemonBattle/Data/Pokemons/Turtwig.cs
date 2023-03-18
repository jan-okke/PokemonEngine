using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Turtwig : Pokemon
	{
		public override string Name => "Turtwig";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(55, 68, 64, 31, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[5] = new List<Move>() { new Withdraw() },
			[6] = new List<Move>() { new Leafage() },
			[10] = new List<Move>() { new Growth() },
			[13] = new List<Move>() { new Razorleaf() },
			[17] = new List<Move>() { new Curse() },
			[21] = new List<Move>() { new Bite() },
			[25] = new List<Move>() { new Megadrain() },
			[29] = new List<Move>() { new Leechseed() },
			[33] = new List<Move>() { new Synthesis() },
			[37] = new List<Move>() { new Crunch() },
			[41] = new List<Move>() { new Gigadrain() },
			[45] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Earthpower(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Naturepower(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockclimb(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Workup(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Bodyslam(), new Doubleedge(), new Earthpower(), new Grassyterrain(), new Growth(), new Heavyslam(), new Sandtomb(), new Seedbomb(), new Spitup(), new Stockpile(), new Superpower(), new Swallow(), new Thrash(), new Tickle(), new Wideguard(), new Worryseed() };
		public override int Weight => 102;
		public override int ExpYield => 64;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}