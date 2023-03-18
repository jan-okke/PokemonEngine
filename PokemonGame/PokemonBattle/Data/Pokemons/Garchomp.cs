using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Garchomp : Pokemon
	{
		public override string Name => "Garchomp";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Roughskin() };
		public override Stats BaseStats => new Stats(108, 130, 95, 102, 80, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Crunch() },
			[1] = new List<Move>() { new Crunch(), new Dualchop(), new Sandtomb(), new Tackle(), new Sandattack(), new Dragonbreath() },
			[18] = new List<Move>() { new Bulldoze() },
			[27] = new List<Move>() { new Bite() },
			[34] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Dragonclaw() },
			[52] = new List<Move>() { new Dig() },
			[62] = new List<Move>() { new Sandstorm() },
			[72] = new List<Move>() { new Takedown() },
			[82] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firefang(), new Flamethrower(), new Fling(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Mudshot(), new Outrage(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Whirlpool() };
		public override int Weight => 950;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}