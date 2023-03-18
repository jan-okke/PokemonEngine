using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seedot : Pokemon
	{
		public override string Name => "Seedot";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(40, 40, 50, 30, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[3] = new List<Move>() { new Absorb() },
			[6] = new List<Move>() { new Astonish() },
			[9] = new List<Move>() { new Growth() },
			[12] = new List<Move>() { new Rollout() },
			[15] = new List<Move>() { new Megadrain() },
			[18] = new List<Move>() { new Payback() },
			[21] = new List<Move>() { new Naturepower() },
			[24] = new List<Move>() { new Sunnyday() },
			[27] = new List<Move>() { new Synthesis() },
			[30] = new List<Move>() { new Suckerpunch() },
			[33] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Beatup(), new Bodyslam(), new Bulletseed(), new Dig(), new Doubleteam(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Falseswipe(), new Flash(), new Foulplay(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Nastyplot(), new Payback(), new Powerswap(), new Protect(), new Rest(), new Retaliate(), new Rocksmash(), new Round(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Beatup(), new Foulplay(), new Grassyterrain(), new Leechseed(), new Nightslash(), new Powerswap(), new Quickattack(), new Takedown(), new Worryseed() };
		public override int Weight => 40;
		public override int ExpYield => 44;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}