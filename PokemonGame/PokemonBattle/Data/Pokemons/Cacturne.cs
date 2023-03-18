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
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(70, 115, 60, 55, 115, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Spikyshield() },
			[1] = new List<Move>() { new Spikyshield(), new Destinybond(), new Revenge(), new Poisonsting(), new Leer(), new Absorb(), new Growth() },
			[4] = new List<Move>() { new Absorb() },
			[7] = new List<Move>() { new Growth() },
			[10] = new List<Move>() { new Leechseed() },
			[13] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Poisonjab() },
			[19] = new List<Move>() { new Assurance() },
			[22] = new List<Move>() { new Ingrain() },
			[26] = new List<Move>() { new Payback() },
			[30] = new List<Move>() { new Spikes() },
			[35] = new List<Move>() { new Suckerpunch() },
			[38] = new List<Move>() { new Pinmissile() },
			[44] = new List<Move>() { new Energyball() },
			[49] = new List<Move>() { new Cottonspore() },
			[54] = new List<Move>() { new Sandstorm() },
			[59] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Brickbreak(), new Bulletseed(), new Confide(), new Cut(), new Darkpulse(), new Doubleteam(), new Drainpunch(), new Embargo(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Lowkick(), new Nastyplot(), new Naturepower(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roleplay(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spite(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Thunderpunch(), new Venoshock(), new Worryseed() };
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