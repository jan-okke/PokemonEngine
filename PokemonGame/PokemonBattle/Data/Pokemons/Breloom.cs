using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Breloom : Pokemon
	{
		public override string Name => "Breloom";
		public override List<Ability> AvailableAbilities => new() {new Effectspore(), new Poisonheal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(60, 130, 80, 70, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Machpunch() },
			[1] = new List<Move>() { new Machpunch(), new Absorb(), new Tackle(), new Stunspore(), new Leechseed() },
			[5] = new List<Move>() { new Stunspore() },
			[8] = new List<Move>() { new Leechseed() },
			[12] = new List<Move>() { new Megadrain() },
			[15] = new List<Move>() { new Headbutt() },
			[19] = new List<Move>() { new Feint() },
			[22] = new List<Move>() { new Counter() },
			[28] = new List<Move>() { new Forcepalm() },
			[33] = new List<Move>() { new Mindreader() },
			[39] = new List<Move>() { new Drainpunch() },
			[44] = new List<Move>() { new Seedbomb() },
			[50] = new List<Move>() { new Dynamicpunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Laserfocus(), new Lowsweep(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snatch(), new Snore(), new Solarbeam(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Thunderpunch(), new Venoshock(), new Workup(), new Worryseed() };
		public override int Weight => 392;
		public override int ExpYield => 161;
		public override int CatchRate => 90;
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