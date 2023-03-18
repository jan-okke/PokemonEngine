using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pupitar : Pokemon
	{
		public override string Name => "Pupitar";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
		public override Stats BaseStats => new Stats(70, 84, 70, 65, 70, 51);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Irondefense() },
			[1] = new List<Move>() { new Moves.Irondefense(), new Moves.Tackle(), new Moves.Leer(), new Moves.Rockthrow(), new Moves.Payback() },
			[9] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[15] = new List<Move>() { new Moves.Rockslide() },
			[18] = new List<Move>() { new Moves.Stompingtantrum() },
			[21] = new List<Move>() { new Moves.Screech() },
			[24] = new List<Move>() { new Moves.Darkpulse() },
			[27] = new List<Move>() { new Moves.Crunch() },
			[33] = new List<Move>() { new Moves.Earthquake() },
			[37] = new List<Move>() { new Moves.Stoneedge() },
			[42] = new List<Move>() { new Moves.Thrash() },
			[47] = new List<Move>() { new Moves.Sandstorm() },
			[52] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Torment(), new Moves.Uproar() };
		public override int Weight => 1520;
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