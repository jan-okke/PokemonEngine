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
		public override List<Ability> AvailableAbilities => new() {new Shedskin() };
		public override Stats BaseStats => new Stats(70, 84, 70, 65, 70, 51);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Irondefense() },
			[1] = new List<Move>() { new Irondefense(), new Tackle(), new Leer(), new Rockthrow(), new Payback() },
			[9] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Rockslide() },
			[18] = new List<Move>() { new Stompingtantrum() },
			[21] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Darkpulse() },
			[27] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Earthquake() },
			[37] = new List<Move>() { new Stoneedge() },
			[42] = new List<Move>() { new Thrash() },
			[47] = new List<Move>() { new Sandstorm() },
			[52] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragondance(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Focusenergy(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Irontail(), new Muddywater(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Taunt(), new Torment(), new Uproar() };
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