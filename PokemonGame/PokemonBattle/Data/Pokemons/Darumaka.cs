using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Darumaka : Pokemon
	{
		public override string Name => "Darumaka";
		public override List<Ability> AvailableAbilities => new() {new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(70, 90, 45, 50, 15, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Ember(), new Tackle() },
			[4] = new List<Move>() { new Taunt() },
			[8] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Incinerate() },
			[16] = new List<Move>() { new Workup() },
			[20] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Firepunch() },
			[32] = new List<Move>() { new Uproar() },
			[36] = new List<Move>() { new Bellydrum() },
			[40] = new List<Move>() { new Flareblitz() },
			[44] = new List<Move>() { new Thrash() },
			[48] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Dig(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusenergy(), new Grassknot(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Megakick(), new Megapunch(), new Overheat(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Uproar(), new Uturn(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Extrasensory(), new Flamewheel(), new Focuspunch(), new Hammerarm(), new Takedown(), new Yawn() };
		public override int Weight => 375;
		public override int ExpYield => 63;
		public override int CatchRate => 120;
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