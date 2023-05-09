using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Corphish : Pokemon
{
	public override string Name => "Corphish";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(43, 80, 65, 50, 35, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Harden() },
		[4] = new List<Move>() { new Moves.Leer() },
		[8] = new List<Move>() { new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Bubblebeam() },
		[16] = new List<Move>() { new Moves.Knockoff() },
		[20] = new List<Move>() { new Moves.Doublehit() },
		[24] = new List<Move>() { new Moves.Protect() },
		[28] = new List<Move>() { new Moves.Nightslash() },
		[32] = new List<Move>() { new Moves.Razorshell() },
		[36] = new List<Move>() { new Moves.Swordsdance() },
		[40] = new List<Move>() { new Moves.Crunch() },
		[44] = new List<Move>() { new Moves.Crabhammer() },
		[48] = new List<Move>() { new Moves.Endeavor() },
		[52] = new List<Move>() { new Moves.Guillotine() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Aquajet(), new Moves.Bodyslam(), new Moves.Doubleedge(), new Moves.Dragondance(), new Moves.Endeavor(), new Moves.Knockoff(), new Moves.Metalclaw(), new Moves.Slash(), new Moves.Superpower(), new Moves.Switcheroo() };
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