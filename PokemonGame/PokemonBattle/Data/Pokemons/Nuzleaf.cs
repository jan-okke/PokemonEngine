using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nuzleaf : Pokemon
	{
		public override string Name => "Nuzleaf";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(70, 70, 40, 60, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Razorleaf() },
			[1] = new List<Move>() { new Razorleaf(), new Aircutter(), new Torment(), new Fakeout(), new Swagger(), new Synthesis(), new Explosion(), new Tackle(), new Harden(), new Absorb(), new Astonish() },
			[9] = new List<Move>() { new Growth() },
			[12] = new List<Move>() { new Rollout() },
			[18] = new List<Move>() { new Megadrain() },
			[24] = new List<Move>() { new Payback() },
			[30] = new List<Move>() { new Naturepower() },
			[36] = new List<Move>() { new Sunnyday() },
			[43] = new List<Move>() { new Extrasensory() },
			[50] = new List<Move>() { new Suckerpunch() },
			[57] = new List<Move>() { new Leafblade() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Brickbreak(), new Bulletseed(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Falseswipe(), new Flash(), new Fling(), new Foulplay(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Lashout(), new Leafblade(), new Lowkick(), new Lowsweep(), new Megakick(), new Nastyplot(), new Payback(), new Powerswap(), new Protect(), new Psychup(), new Rest(), new Retaliate(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Solarblade(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Torment() };
		public override int Weight => 280;
		public override int ExpYield => 119;
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