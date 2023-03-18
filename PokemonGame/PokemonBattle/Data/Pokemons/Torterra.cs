using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Torterra : Pokemon
	{
		public override string Name => "Torterra";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(95, 109, 105, 75, 85, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Earthquake() },
			[1] = new List<Move>() { new Earthquake(), new Woodhammer(), new Tackle(), new Withdraw(), new Absorb(), new Razorleaf() },
			[5] = new List<Move>() { new Withdraw() },
			[6] = new List<Move>() { new Leafage() },
			[10] = new List<Move>() { new Growth() },
			[13] = new List<Move>() { new Razorleaf() },
			[17] = new List<Move>() { new Curse() },
			[22] = new List<Move>() { new Bite() },
			[27] = new List<Move>() { new Megadrain() },
			[33] = new List<Move>() { new Leechseed() },
			[39] = new List<Move>() { new Synthesis() },
			[45] = new List<Move>() { new Crunch() },
			[51] = new List<Move>() { new Gigadrain() },
			[57] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Bulldoze(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frenzyplant(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Lightscreen(), new Naturepower(), new Outrage(), new Protect(), new Reflect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Workup(), new Worryseed() };
		public override int Weight => 3100;
		public override int ExpYield => 263;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}