using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cacturne : Pokemon
	{
		public override string Name => "Cacturne";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
		public override Stats BaseStats => new Stats(70, 115, 60, 115, 60, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Spikyshield() },
			[1] = new List<Move>() { new Moves.Spikyshield(), new Moves.Destinybond(), new Moves.Revenge(), new Moves.Poisonsting(), new Moves.Leer(), new Moves.Absorb(), new Moves.Growth() },
			[4] = new List<Move>() { new Moves.Absorb() },
			[7] = new List<Move>() { new Moves.Growth() },
			[10] = new List<Move>() { new Moves.Leechseed() },
			[13] = new List<Move>() { new Moves.Sandattack() },
			[16] = new List<Move>() { new Moves.Poisonjab() },
			[19] = new List<Move>() { new Moves.Assurance() },
			[22] = new List<Move>() { new Moves.Ingrain() },
			[26] = new List<Move>() { new Moves.Payback() },
			[30] = new List<Move>() { new Moves.Spikes() },
			[35] = new List<Move>() { new Moves.Suckerpunch() },
			[38] = new List<Move>() { new Moves.Pinmissile() },
			[44] = new List<Move>() { new Moves.Energyball() },
			[49] = new List<Move>() { new Moves.Cottonspore() },
			[54] = new List<Move>() { new Moves.Sandstorm() },
			[59] = new List<Move>() { new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Embargo(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lowkick(), new Moves.Nastyplot(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spite(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thunderpunch(), new Moves.Venoshock(), new Moves.Worryseed() };
		public override int Weight => 774;
		public override int ExpYield => 166;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}