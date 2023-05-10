using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Virizion : Pokemon
{
	public override string Name => "Virizion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(91, 90, 72, 90, 129, 108);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer(), new Moves.Helpinghand(), new Moves.Workup() },
		[7] = new List<Move>() { new Moves.Magicalleaf() },
		[14] = new List<Move>() { new Moves.Quickguard() },
		[21] = new List<Move>() { new Moves.Doublekick() },
		[28] = new List<Move>() { new Moves.Retaliate() },
		[35] = new List<Move>() { new Moves.Gigadrain() },
		[42] = new List<Move>() { new Moves.Takedown() },
		[49] = new List<Move>() { new Moves.Sacredsword() },
		[56] = new List<Move>() { new Moves.Swordsdance() },
		[63] = new List<Move>() { new Moves.Leafblade() },
		[70] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megahorn(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 2000;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}