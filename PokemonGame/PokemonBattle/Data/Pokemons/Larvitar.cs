using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Larvitar : Pokemon
	{
		public override string Name => "Larvitar";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
		public override Stats BaseStats => new Stats(50, 64, 50, 45, 50, 41);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
			[3] = new List<Move>() { new Moves.Rockthrow() },
			[6] = new List<Move>() { new Moves.Payback() },
			[9] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[15] = new List<Move>() { new Moves.Rockslide() },
			[18] = new List<Move>() { new Moves.Stompingtantrum() },
			[21] = new List<Move>() { new Moves.Screech() },
			[24] = new List<Move>() { new Moves.Darkpulse() },
			[27] = new List<Move>() { new Moves.Crunch() },
			[31] = new List<Move>() { new Moves.Earthquake() },
			[33] = new List<Move>() { new Moves.Stoneedge() },
			[36] = new List<Move>() { new Moves.Thrash() },
			[39] = new List<Move>() { new Moves.Sandstorm() },
			[42] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Torment(), new Moves.Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Assurance(), new Moves.Curse(), new Moves.Dragondance(), new Moves.Focusenergy(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Outrage(), new Moves.Stomp() };
		public override int Weight => 720;
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