using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Patrat : Pokemon
	{
		public override string Name => "Patrat";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(45, 55, 39, 42, 35, 39);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[3] = new List<Move>() { new Leer() },
			[6] = new List<Move>() { new Bite() },
			[8] = new List<Move>() { new Bide() },
			[11] = new List<Move>() { new Detect() },
			[13] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Crunch() },
			[18] = new List<Move>() { new Hypnosis() },
			[21] = new List<Move>() { new Superfang() },
			[23] = new List<Move>() { new Afteryou() },
			[26] = new List<Move>() { new Focusenergy() },
			[28] = new List<Move>() { new Workup() },
			[31] = new List<Move>() { new Hyperfang() },
			[33] = new List<Move>() { new Nastyplot() },
			[36] = new List<Move>() { new Meanlook() },
			[38] = new List<Move>() { new Batonpass() },
			[41] = new List<Move>() { new Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Aquatail(), new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Endeavor(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Laserfocus(), new Lastresort(), new Lowkick(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Seedbomb(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Swordsdance(), new Thunderbolt(), new Toxic(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Bulletseed(), new Flail(), new Foresight(), new Irontail(), new Pursuit(), new Revenge(), new Screech(), new Tearfullook() };
		public override int Weight => 116;
		public override int ExpYield => 51;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}