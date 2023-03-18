using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Corphish : Pokemon
	{
		public override string Name => "Corphish";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(43, 80, 65, 35, 50, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Harden() },
			[4] = new List<Move>() { new Leer() },
			[8] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Knockoff() },
			[20] = new List<Move>() { new Doublehit() },
			[24] = new List<Move>() { new Protect() },
			[28] = new List<Move>() { new Nightslash() },
			[32] = new List<Move>() { new Razorshell() },
			[36] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Crunch() },
			[44] = new List<Move>() { new Crabhammer() },
			[48] = new List<Move>() { new Endeavor() },
			[52] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragondance(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Muddywater(), new Mudshot(), new Payback(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Aquajet(), new Bodyslam(), new Doubleedge(), new Dragondance(), new Endeavor(), new Knockoff(), new Metalclaw(), new Slash(), new Superpower(), new Switcheroo() };
		public override int Weight => 115;
		public override int ExpYield => 62;
		public override int CatchRate => 205;
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