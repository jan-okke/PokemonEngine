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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(65, 95, 100, 60, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Protect() },
			[1] = new List<Move>() { new Moves.Protect(), new Moves.Ember(), new Moves.Leer(), new Moves.Bite(), new Moves.Dragonbreath() },
			[15] = new List<Move>() { new Moves.Headbutt() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Crunch() },
			[33] = new List<Move>() { new Moves.Dragonclaw() },
			[39] = new List<Move>() { new Moves.Zenheadbutt() },
			[46] = new List<Move>() { new Moves.Focusenergy() },
			[53] = new List<Move>() { new Moves.Flamethrower() },
			[60] = new List<Move>() { new Moves.Outrage() },
			[67] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Crunch(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Zenheadbutt() };
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