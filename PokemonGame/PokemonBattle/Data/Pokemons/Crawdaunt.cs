using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Crawdaunt : Pokemon
{
	public override string Name => "Crawdaunt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(63, 120, 85, 90, 55, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Swift() },
		[1] = new List<Move>() { new Moves.Swift(), new Moves.Watergun(), new Moves.Harden(), new Moves.Leer(), new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Bubblebeam() },
		[16] = new List<Move>() { new Moves.Knockoff() },
		[20] = new List<Move>() { new Moves.Doublehit() },
		[24] = new List<Move>() { new Moves.Protect() },
		[28] = new List<Move>() { new Moves.Nightslash() },
		[34] = new List<Move>() { new Moves.Razorshell() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[46] = new List<Move>() { new Moves.Crunch() },
		[52] = new List<Move>() { new Moves.Crabhammer() },
		[58] = new List<Move>() { new Moves.Endeavor() },
		[64] = new List<Move>() { new Moves.Guillotine() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lashout(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Xscissor() };
	public override int Weight => 328;
	public override int ExpYield => 164;
	public override int CatchRate => 155;
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