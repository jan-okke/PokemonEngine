using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shelgon : Pokemon
	{
		public override string Name => "Shelgon";
		public override List<Ability> AvailableAbilities => new() {new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(65, 95, 100, 50, 60, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Protect() },
			[1] = new List<Move>() { new Protect(), new Ember(), new Leer(), new Bite(), new Dragonbreath() },
			[15] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Dragonclaw() },
			[39] = new List<Move>() { new Zenheadbutt() },
			[46] = new List<Move>() { new Focusenergy() },
			[53] = new List<Move>() { new Flamethrower() },
			[60] = new List<Move>() { new Outrage() },
			[67] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Brickbreak(), new Crunch(), new Cut(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Focusenergy(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Irondefense(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Zenheadbutt() };
		public override int Weight => 1105;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}