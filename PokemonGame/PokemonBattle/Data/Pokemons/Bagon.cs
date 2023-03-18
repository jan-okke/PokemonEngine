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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(45, 75, 60, 40, 30, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Ember(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Bite() },
			[10] = new List<Move>() { new Moves.Dragonbreath() },
			[15] = new List<Move>() { new Moves.Headbutt() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Crunch() },
			[31] = new List<Move>() { new Moves.Dragonclaw() },
			[35] = new List<Move>() { new Moves.Zenheadbutt() },
			[40] = new List<Move>() { new Moves.Focusenergy() },
			[45] = new List<Move>() { new Moves.Flamethrower() },
			[50] = new List<Move>() { new Moves.Outrage() },
			[55] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Crunch(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Dragondance(), new Moves.Dragonrush(), new Moves.Firefang(), new Moves.Hydropump(), new Moves.Thrash(), new Moves.Twister() };
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