using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Darmanitan : Pokemon
	{
		public override string Name => "Darmanitan";
		public override List<Ability> AvailableAbilities => new() {new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Zenmode() };
		public override Stats BaseStats => new Stats(105, 140, 55, 30, 55, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hammerarm() },
			[1] = new List<Move>() { new Hammerarm(), new Ember(), new Tackle(), new Taunt(), new Bite() },
			[12] = new List<Move>() { new Incinerate() },
			[16] = new List<Move>() { new Workup() },
			[20] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Firepunch() },
			[32] = new List<Move>() { new Uproar() },
			[38] = new List<Move>() { new Bellydrum() },
			[44] = new List<Move>() { new Flareblitz() },
			[50] = new List<Move>() { new Thrash() },
			[56] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Burningjealousy(), new Dig(), new Earthquake(), new Encore(), new Endure(), new Expandingforce(), new Facade(), new Fireblast(), new Firefang(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lashout(), new Megakick(), new Megapunch(), new Mysticalfire(), new Overheat(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Rest(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Trick(), new Uproar(), new Uturn(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override int Weight => 929;
		public override int ExpYield => 168;
		public override int CatchRate => 60;
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