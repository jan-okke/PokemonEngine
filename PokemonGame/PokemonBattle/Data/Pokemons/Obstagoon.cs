using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Obstagoon : Pokemon
	{
		public override string Name => "Obstagoon";
		public override List<Ability> AvailableAbilities => new() {new Reckless(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(93, 90, 101, 95, 60, 81);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Obstruct() },
			[1] = new List<Move>() { new Obstruct(), new Crosschop(), new Submission(), new Nightslash(), new Switcheroo(), new Pinmissile(), new Babydolleyes(), new Tackle(), new Leer(), new Sandattack(), new Lick() },
			[9] = new List<Move>() { new Snarl() },
			[12] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Honeclaws() },
			[18] = new List<Move>() { new Furyswipes() },
			[23] = new List<Move>() { new Rest() },
			[28] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Scaryface() },
			[42] = new List<Move>() { new Counter() },
			[49] = new List<Move>() { new Taunt() },
			[56] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Closecombat(), new Crosspoison(), new Dig(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Irondefense(), new Irontail(), new Lashout(), new Lowkick(), new Megakick(), new Megapunch(), new Mudshot(), new Payback(), new Pinmissile(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Surf(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trick(), new Whirlpool(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Knockoff(), new Partingshot(), new Quickguard() };
		public override int Weight => 460;
		public override int ExpYield => 260;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}