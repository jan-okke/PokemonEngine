using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Terrakion : Pokemon
{
	public override string Name => "Terrakion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(91, 129, 90, 72, 90, 108);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer(), new Moves.Helpinghand(), new Moves.Workup() },
		[7] = new List<Move>() { new Moves.Smackdown() },
		[14] = new List<Move>() { new Moves.Quickguard() },
		[21] = new List<Move>() { new Moves.Doublekick() },
		[28] = new List<Move>() { new Moves.Retaliate() },
		[35] = new List<Move>() { new Moves.Rockslide() },
		[42] = new List<Move>() { new Moves.Takedown() },
		[49] = new List<Move>() { new Moves.Sacredsword() },
		[56] = new List<Move>() { new Moves.Swordsdance() },
		[63] = new List<Move>() { new Moves.Stoneedge() },
		[70] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Megahorn(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 2600;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}