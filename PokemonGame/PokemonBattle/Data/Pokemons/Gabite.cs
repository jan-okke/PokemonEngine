using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gabite : Pokemon
	{
		public override string Name => "Gabite";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Roughskin() };
		public override Stats BaseStats => new Stats(68, 90, 65, 82, 50, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dualchop(), new Sandtomb(), new Tackle(), new Sandattack(), new Dragonbreath() },
			[18] = new List<Move>() { new Bulldoze() },
			[27] = new List<Move>() { new Bite() },
			[34] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Dragonclaw() },
			[50] = new List<Move>() { new Dig() },
			[58] = new List<Move>() { new Sandstorm() },
			[66] = new List<Move>() { new Takedown() },
			[74] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Hiddenpower(), new Ironhead(), new Irontail(), new Mudshot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift() };
		public override int Weight => 560;
		public override int ExpYield => 144;
		public override int CatchRate => 45;
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