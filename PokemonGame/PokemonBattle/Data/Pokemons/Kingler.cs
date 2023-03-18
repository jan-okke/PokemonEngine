using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kingler : Pokemon
	{
		public override string Name => "Kingler";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(55, 130, 115, 50, 50, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wideguard(), new Moves.Hammerarm(), new Moves.Watergun(), new Moves.Leer(), new Moves.Harden(), new Moves.Metalclaw() },
			[12] = new List<Move>() { new Moves.Mudshot() },
			[16] = new List<Move>() { new Moves.Protect() },
			[20] = new List<Move>() { new Moves.Bubblebeam() },
			[24] = new List<Move>() { new Moves.Stomp() },
			[31] = new List<Move>() { new Moves.Flail() },
			[36] = new List<Move>() { new Moves.Razorshell() },
			[42] = new List<Move>() { new Moves.Slam() },
			[48] = new List<Move>() { new Moves.Swordsdance() },
			[54] = new List<Move>() { new Moves.Crabhammer() },
			[60] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Xscissor() };
		public override int Weight => 600;
		public override int ExpYield => 166;
		public override int CatchRate => 60;
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