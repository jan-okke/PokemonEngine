using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Arctozolt : Pokemon
{
	public override string Name => "Arctozolt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Voltabsorb(), new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Slushrush() };
	public override Stats BaseStats => new Stats(90, 100, 90, 90, 80, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Thundershock() },
		[7] = new List<Move>() { new Moves.Charge() },
		[14] = new List<Move>() { new Moves.Echoedvoice() },
		[21] = new List<Move>() { new Moves.Ancientpower() },
		[28] = new List<Move>() { new Moves.Pluck() },
		[35] = new List<Move>() { new Moves.Avalanche() },
		[42] = new List<Move>() { new Moves.Freezedry() },
		[49] = new List<Move>() { new Moves.Slam() },
		[56] = new List<Move>() { new Moves.Discharge() },
		[63] = new List<Move>() { new Moves.Boltbeak() },
		[70] = new List<Move>() { new Moves.Iciclecrash() },
		[77] = new List<Move>() { new Moves.Blizzard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Wildcharge() };
	public override int Weight => 1500;
	public override int ExpYield => 177;
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