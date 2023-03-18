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
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(55, 130, 115, 75, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wideguard(), new Hammerarm(), new Watergun(), new Leer(), new Harden(), new Metalclaw() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Stomp() },
			[31] = new List<Move>() { new Flail() },
			[36] = new List<Move>() { new Razorshell() },
			[42] = new List<Move>() { new Slam() },
			[48] = new List<Move>() { new Swordsdance() },
			[54] = new List<Move>() { new Crabhammer() },
			[60] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Brutalswing(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Mudshot(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Waterpulse(), new Whirlpool(), new Xscissor() };
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