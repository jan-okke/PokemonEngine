using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gible : Pokemon
	{
		public override string Name => "Gible";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Roughskin() };
		public override Stats BaseStats => new Stats(58, 70, 45, 40, 45, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandtomb(), new Tackle() },
			[6] = new List<Move>() { new Sandattack() },
			[12] = new List<Move>() { new Dragonbreath() },
			[18] = new List<Move>() { new Bulldoze() },
			[25] = new List<Move>() { new Bite() },
			[30] = new List<Move>() { new Slash() },
			[36] = new List<Move>() { new Dragonclaw() },
			[42] = new List<Move>() { new Dig() },
			[48] = new List<Move>() { new Sandstorm() },
			[54] = new List<Move>() { new Takedown() },
			[60] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Hiddenpower(), new Ironhead(), new Irontail(), new Mudshot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Doubleedge(), new Dragonbreath(), new Ironhead(), new Metalclaw(), new Mudshot(), new Outrage(), new Sandtomb(), new Scaryface(), new Thrash(), new Twister() };
		public override int Weight => 205;
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