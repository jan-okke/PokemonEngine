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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
		public override Stats BaseStats => new Stats(70, 90, 45, 15, 45, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Ember(), new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Taunt() },
			[8] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Incinerate() },
			[16] = new List<Move>() { new Moves.Workup() },
			[20] = new List<Move>() { new Moves.Firefang() },
			[24] = new List<Move>() { new Moves.Headbutt() },
			[28] = new List<Move>() { new Moves.Firepunch() },
			[32] = new List<Move>() { new Moves.Uproar() },
			[36] = new List<Move>() { new Moves.Bellydrum() },
			[40] = new List<Move>() { new Moves.Flareblitz() },
			[44] = new List<Move>() { new Moves.Thrash() },
			[48] = new List<Move>() { new Moves.Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Dig(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Extrasensory(), new Moves.Flamewheel(), new Moves.Focuspunch(), new Moves.Hammerarm(), new Moves.Takedown(), new Moves.Yawn() };
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