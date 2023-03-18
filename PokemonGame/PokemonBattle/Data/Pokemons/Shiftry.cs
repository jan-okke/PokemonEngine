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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
		public override Stats BaseStats => new Stats(90, 100, 60, 90, 60, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Leaftornado() },
			[1] = new List<Move>() { new Moves.Leaftornado(), new Moves.Razorleaf(), new Moves.Aircutter(), new Moves.Torment(), new Moves.Fakeout(), new Moves.Swagger(), new Moves.Whirlwind(), new Moves.Hurricane(), new Moves.Synthesis(), new Moves.Explosion(), new Moves.Growth(), new Moves.Rollout(), new Moves.Megadrain(), new Moves.Payback(), new Moves.Naturepower(), new Moves.Sunnyday(), new Moves.Extrasensory(), new Moves.Suckerpunch(), new Moves.Leafblade(), new Moves.Tackle(), new Moves.Harden(), new Moves.Absorb(), new Moves.Astonish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Explosion(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Lashout(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Xscissor() };
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