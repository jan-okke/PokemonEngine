using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pancham : Pokemon
{
	public override string Name => "Pancham";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironfist(), new Abilities.Moldbreaker() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
	public override Stats BaseStats => new Stats(67, 82, 62, 46, 48, 43);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Armthrust() },
		[8] = new List<Move>() { new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Circlethrow() },
		[16] = new List<Move>() { new Moves.Lowsweep() },
		[20] = new List<Move>() { new Moves.Workup() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Vitalthrow() },
		[33] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Bodyslam() },
		[40] = new List<Move>() { new Moves.Partingshot() },
		[44] = new List<Move>() { new Moves.Entrainment() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Powertrip(), new Moves.Quash(), new Moves.Quickguard(), new Moves.Seismictoss(), new Moves.Stormthrow() };
	public override int Weight => 80;
	public override int ExpYield => 70;
	public override int CatchRate => 220;
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