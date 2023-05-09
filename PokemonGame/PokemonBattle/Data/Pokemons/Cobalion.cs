using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cobalion : Pokemon
{
	public override string Name => "Cobalion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(91, 90, 129, 90, 72, 108);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer(), new Moves.Helpinghand(), new Moves.Workup() },
		[7] = new List<Move>() { new Moves.Metalclaw() },
		[14] = new List<Move>() { new Moves.Quickguard() },
		[21] = new List<Move>() { new Moves.Doublekick() },
		[28] = new List<Move>() { new Moves.Retaliate() },
		[35] = new List<Move>() { new Moves.Metalburst() },
		[42] = new List<Move>() { new Moves.Takedown() },
		[49] = new List<Move>() { new Moves.Sacredsword() },
		[56] = new List<Move>() { new Moves.Swordsdance() },
		[63] = new List<Move>() { new Moves.Ironhead() },
		[70] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megahorn(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 2500;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
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