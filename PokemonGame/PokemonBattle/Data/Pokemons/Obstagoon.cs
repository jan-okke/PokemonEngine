using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Obstagoon : Pokemon
{
	public override string Name => "Obstagoon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Reckless(), new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(93, 90, 101, 60, 81, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Obstruct() },
		[1] = new List<Move>() { new Moves.Obstruct(), new Moves.Crosschop(), new Moves.Submission(), new Moves.Nightslash(), new Moves.Switcheroo(), new Moves.Pinmissile(), new Moves.Babydolleyes(), new Moves.Tackle(), new Moves.Leer(), new Moves.Sandattack(), new Moves.Lick() },
		[9] = new List<Move>() { new Moves.Snarl() },
		[12] = new List<Move>() { new Moves.Headbutt() },
		[15] = new List<Move>() { new Moves.Honeclaws() },
		[18] = new List<Move>() { new Moves.Furyswipes() },
		[23] = new List<Move>() { new Moves.Rest() },
		[28] = new List<Move>() { new Moves.Takedown() },
		[35] = new List<Move>() { new Moves.Scaryface() },
		[42] = new List<Move>() { new Moves.Counter() },
		[49] = new List<Move>() { new Moves.Taunt() },
		[56] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Crosspoison(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Knockoff(), new Moves.Partingshot(), new Moves.Quickguard() };
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