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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shellarmor() };
		public override Stats BaseStats => new Stats(95, 109, 105, 75, 85, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Earthquake() },
			[1] = new List<Move>() { new Moves.Earthquake(), new Moves.Woodhammer(), new Moves.Tackle(), new Moves.Withdraw(), new Moves.Absorb(), new Moves.Razorleaf() },
			[5] = new List<Move>() { new Moves.Withdraw() },
			[6] = new List<Move>() { new Moves.Leafage() },
			[10] = new List<Move>() { new Moves.Growth() },
			[13] = new List<Move>() { new Moves.Razorleaf() },
			[17] = new List<Move>() { new Moves.Curse() },
			[22] = new List<Move>() { new Moves.Bite() },
			[27] = new List<Move>() { new Moves.Megadrain() },
			[33] = new List<Move>() { new Moves.Leechseed() },
			[39] = new List<Move>() { new Moves.Synthesis() },
			[45] = new List<Move>() { new Moves.Crunch() },
			[51] = new List<Move>() { new Moves.Gigadrain() },
			[57] = new List<Move>() { new Moves.Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frenzyplant(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Outrage(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Workup(), new Moves.Worryseed() };
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