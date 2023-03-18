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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(30, 105, 90, 25, 25, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Harden() },
			[8] = new List<Move>() { new Moves.Metalclaw() },
			[12] = new List<Move>() { new Moves.Mudshot() },
			[16] = new List<Move>() { new Moves.Protect() },
			[20] = new List<Move>() { new Moves.Bubblebeam() },
			[24] = new List<Move>() { new Moves.Stomp() },
			[29] = new List<Move>() { new Moves.Flail() },
			[32] = new List<Move>() { new Moves.Razorshell() },
			[36] = new List<Move>() { new Moves.Slam() },
			[40] = new List<Move>() { new Moves.Swordsdance() },
			[44] = new List<Move>() { new Moves.Crabhammer() },
			[48] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Ancientpower(), new Moves.Flail(), new Moves.Hammerarm(), new Moves.Haze(), new Moves.Knockoff(), new Moves.Nightslash(), new Moves.Slam(), new Moves.Slash(), new Moves.Tickle() };
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