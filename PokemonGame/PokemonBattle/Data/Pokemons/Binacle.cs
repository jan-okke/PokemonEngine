using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Binacle : Pokemon
{
	public override string Name => "Binacle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Toughclaws(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
	public override Stats BaseStats => new Stats(42, 52, 67, 39, 56, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Mudslap() },
		[4] = new List<Move>() { new Moves.Withdraw() },
		[8] = new List<Move>() { new Moves.Watergun() },
		[12] = new List<Move>() { new Moves.Furycutter() },
		[16] = new List<Move>() { new Moves.Furyswipes() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[24] = new List<Move>() { new Moves.Rockpolish() },
		[28] = new List<Move>() { new Moves.Slash() },
		[32] = new List<Move>() { new Moves.Honeclaws() },
		[36] = new List<Move>() { new Moves.Razorshell() },
		[40] = new List<Move>() { new Moves.Shellsmash() },
		[44] = new List<Move>() { new Moves.Crosschop() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Nightslash(), new Moves.Sandattack(), new Moves.Switcheroo() };
	public override int Weight => 310;
	public override int ExpYield => 61;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}