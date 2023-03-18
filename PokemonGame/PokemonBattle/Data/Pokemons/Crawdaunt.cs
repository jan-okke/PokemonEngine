using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Crawdaunt : Pokemon
	{
		public override string Name => "Crawdaunt";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(63, 120, 85, 55, 90, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Swift() },
			[1] = new List<Move>() { new Swift(), new Watergun(), new Harden(), new Leer(), new Taunt() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Knockoff() },
			[20] = new List<Move>() { new Doublehit() },
			[24] = new List<Move>() { new Protect() },
			[28] = new List<Move>() { new Nightslash() },
			[34] = new List<Move>() { new Razorshell() },
			[40] = new List<Move>() { new Swordsdance() },
			[46] = new List<Move>() { new Crunch() },
			[52] = new List<Move>() { new Crabhammer() },
			[58] = new List<Move>() { new Endeavor() },
			[64] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Closecombat(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Dive(), new Doubleteam(), new Dragondance(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Lashout(), new Liquidation(), new Muddywater(), new Mudshot(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Xscissor() };
		public override int Weight => 328;
		public override int ExpYield => 164;
		public override int CatchRate => 155;
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