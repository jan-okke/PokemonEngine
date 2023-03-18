using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grotle : Pokemon
	{
		public override string Name => "Grotle";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shellarmor() };
		public override Stats BaseStats => new Stats(75, 89, 85, 55, 65, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Withdraw(), new Moves.Absorb() },
			[5] = new List<Move>() { new Moves.Withdraw() },
			[6] = new List<Move>() { new Moves.Leafage() },
			[10] = new List<Move>() { new Moves.Growth() },
			[13] = new List<Move>() { new Moves.Razorleaf() },
			[17] = new List<Move>() { new Moves.Curse() },
			[22] = new List<Move>() { new Moves.Bite() },
			[27] = new List<Move>() { new Moves.Megadrain() },
			[32] = new List<Move>() { new Moves.Leechseed() },
			[37] = new List<Move>() { new Moves.Synthesis() },
			[42] = new List<Move>() { new Moves.Crunch() },
			[47] = new List<Move>() { new Moves.Gigadrain() },
			[52] = new List<Move>() { new Moves.Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Workup(), new Moves.Worryseed() };
		public override int Weight => 970;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}