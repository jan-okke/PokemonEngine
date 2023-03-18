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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Roughskin() };
		public override Stats BaseStats => new Stats(108, 130, 95, 80, 85, 102);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Crunch() },
			[1] = new List<Move>() { new Moves.Crunch(), new Moves.Dualchop(), new Moves.Sandtomb(), new Moves.Tackle(), new Moves.Sandattack(), new Moves.Dragonbreath() },
			[18] = new List<Move>() { new Moves.Bulldoze() },
			[27] = new List<Move>() { new Moves.Bite() },
			[34] = new List<Move>() { new Moves.Slash() },
			[42] = new List<Move>() { new Moves.Dragonclaw() },
			[52] = new List<Move>() { new Moves.Dig() },
			[62] = new List<Move>() { new Moves.Sandstorm() },
			[72] = new List<Move>() { new Moves.Takedown() },
			[82] = new List<Move>() { new Moves.Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Whirlpool() };
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