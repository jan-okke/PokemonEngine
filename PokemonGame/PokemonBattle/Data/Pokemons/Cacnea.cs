using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cacnea : Pokemon
	{
		public override string Name => "Cacnea";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(50, 85, 40, 35, 85, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Leer() },
			[4] = new List<Move>() { new Absorb() },
			[7] = new List<Move>() { new Growth() },
			[10] = new List<Move>() { new Leechseed() },
			[13] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Poisonjab() },
			[19] = new List<Move>() { new Assurance() },
			[22] = new List<Move>() { new Ingrain() },
			[26] = new List<Move>() { new Payback() },
			[30] = new List<Move>() { new Spikes() },
			[34] = new List<Move>() { new Suckerpunch() },
			[38] = new List<Move>() { new Pinmissile() },
			[42] = new List<Move>() { new Energyball() },
			[46] = new List<Move>() { new Cottonspore() },
			[50] = new List<Move>() { new Sandstorm() },
			[54] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Brickbreak(), new Bulletseed(), new Confide(), new Cut(), new Darkpulse(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Lowkick(), new Nastyplot(), new Naturepower(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roleplay(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spite(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thunderpunch(), new Venoshock(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Acid(), new Belch(), new Block(), new Counter(), new Disable(), new Dynamicpunch(), new Fellstinger(), new Lowkick(), new Magicalleaf(), new Poweruppunch(), new Seedbomb(), new Switcheroo(), new Teeterdance(), new Worryseed() };
		public override int Weight => 513;
		public override int ExpYield => 67;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}