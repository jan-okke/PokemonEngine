using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kabutops : Pokemon
{
	public override string Name => "Kabutops";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Battlearmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(60, 115, 105, 65, 70, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slash() },
		[1] = new List<Move>() { new Moves.Slash(), new Moves.Nightslash(), new Moves.Feint(), new Moves.Absorb(), new Moves.Harden(), new Moves.Scratch(), new Moves.Sandattack() },
		[15] = new List<Move>() { new Moves.Aquajet() },
		[20] = new List<Move>() { new Moves.Leer() },
		[25] = new List<Move>() { new Moves.Mudshot() },
		[30] = new List<Move>() { new Moves.Ancientpower() },
		[35] = new List<Move>() { new Moves.Brine() },
		[43] = new List<Move>() { new Moves.Protect() },
		[49] = new List<Move>() { new Moves.Leechlife() },
		[56] = new List<Move>() { new Moves.Liquidation() },
		[63] = new List<Move>() { new Moves.Metalsound() },
		[70] = new List<Move>() { new Moves.Stoneedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Xscissor() };
	public override int Weight => 405;
	public override int ExpYield => 173;
	public override int CatchRate => 45;
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