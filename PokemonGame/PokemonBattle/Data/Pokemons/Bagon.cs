using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bagon : Pokemon
	{
		public override string Name => "Bagon";
		public override List<Ability> AvailableAbilities => new() {new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(45, 75, 60, 40, 30, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Ember(), new Leer() },
			[5] = new List<Move>() { new Bite() },
			[10] = new List<Move>() { new Dragonbreath() },
			[15] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Crunch() },
			[31] = new List<Move>() { new Dragonclaw() },
			[35] = new List<Move>() { new Zenheadbutt() },
			[40] = new List<Move>() { new Focusenergy() },
			[45] = new List<Move>() { new Flamethrower() },
			[50] = new List<Move>() { new Outrage() },
			[55] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Brickbreak(), new Crunch(), new Cut(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Focusenergy(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Irondefense(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Defensecurl(), new Dragondance(), new Dragonrush(), new Firefang(), new Hydropump(), new Thrash(), new Twister() };
		public override int Weight => 421;
		public override int ExpYield => 60;
		public override int CatchRate => 45;
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