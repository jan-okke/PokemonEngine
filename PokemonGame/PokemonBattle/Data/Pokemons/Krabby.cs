using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Krabby : Pokemon
	{
		public override string Name => "Krabby";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(30, 105, 90, 50, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Leer() },
			[4] = new List<Move>() { new Harden() },
			[8] = new List<Move>() { new Metalclaw() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Stomp() },
			[29] = new List<Move>() { new Flail() },
			[32] = new List<Move>() { new Razorshell() },
			[36] = new List<Move>() { new Slam() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Crabhammer() },
			[48] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Mudshot(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Waterpulse(), new Whirlpool(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Allyswitch(), new Amnesia(), new Ancientpower(), new Flail(), new Hammerarm(), new Haze(), new Knockoff(), new Nightslash(), new Slam(), new Slash(), new Tickle() };
		public override int Weight => 65;
		public override int ExpYield => 65;
		public override int CatchRate => 225;
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