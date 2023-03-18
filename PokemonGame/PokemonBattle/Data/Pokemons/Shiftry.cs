using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shiftry : Pokemon
	{
		public override string Name => "Shiftry";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(90, 100, 60, 80, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Leaftornado() },
			[1] = new List<Move>() { new Leaftornado(), new Razorleaf(), new Aircutter(), new Torment(), new Fakeout(), new Swagger(), new Whirlwind(), new Hurricane(), new Synthesis(), new Explosion(), new Growth(), new Rollout(), new Megadrain(), new Payback(), new Naturepower(), new Sunnyday(), new Extrasensory(), new Suckerpunch(), new Leafblade(), new Tackle(), new Harden(), new Absorb(), new Astonish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Amnesia(), new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Bounce(), new Brickbreak(), new Brutalswing(), new Bulletseed(), new Cut(), new Darkpulse(), new Defog(), new Dig(), new Doubleteam(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Falseswipe(), new Flash(), new Fling(), new Focusblast(), new Foulplay(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Icywind(), new Lashout(), new Leafblade(), new Leafstorm(), new Lowkick(), new Lowsweep(), new Megakick(), new Nastyplot(), new Payback(), new Powerswap(), new Protect(), new Psychup(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Solarblade(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Throatchop(), new Torment(), new Xscissor() };
		public override int Weight => 596;
		public override int ExpYield => 240;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}