using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zangoose : Pokemon
{
	public override string Name => "Zangoose";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Immunity() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Toxicboost() };
	public override Stats BaseStats => new Stats(73, 115, 60, 60, 60, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Quickattack() },
		[8] = new List<Move>() { new Moves.Furycutter() },
		[12] = new List<Move>() { new Moves.Honeclaws() },
		[15] = new List<Move>() { new Moves.Aerialace() },
		[19] = new List<Move>() { new Moves.Slash() },
		[22] = new List<Move>() { new Moves.Revenge() },
		[26] = new List<Move>() { new Moves.Crushclaw() },
		[29] = new List<Move>() { new Moves.Falseswipe() },
		[33] = new List<Move>() { new Moves.Facade() },
		[36] = new List<Move>() { new Moves.Detect() },
		[40] = new List<Move>() { new Moves.Xscissor() },
		[43] = new List<Move>() { new Moves.Taunt() },
		[47] = new List<Move>() { new Moves.Swordsdance() },
		[50] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Embargo(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bellydrum(), new Moves.Counter(), new Moves.Curse(), new Moves.Disable(), new Moves.Doublehit(), new Moves.Doublekick(), new Moves.Feint(), new Moves.Finalgambit(), new Moves.Flail(), new Moves.Furyswipes(), new Moves.Metalclaw(), new Moves.Nightslash(), new Moves.Quickguard() };
	public override int Weight => 403;
	public override int ExpYield => 160;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}