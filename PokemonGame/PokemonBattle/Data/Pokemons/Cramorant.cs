using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cramorant : Pokemon
{
	public override string Name => "Cramorant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Gulpmissile() };
	public override Stats BaseStats => new Stats(70, 85, 55, 85, 95, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Belch(), new Moves.Peck(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[7] = new List<Move>() { new Moves.Watergun() },
		[14] = new List<Move>() { new Moves.Furyattack() },
		[21] = new List<Move>() { new Moves.Pluck() },
		[28] = new List<Move>() { new Moves.Dive() },
		[35] = new List<Move>() { new Moves.Drillpeck() },
		[42] = new List<Move>() { new Moves.Amnesia() },
		[49] = new List<Move>() { new Moves.Thrash() },
		[56] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bravebird(), new Moves.Dive(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Weatherball(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquaring(), new Moves.Defog(), new Moves.Featherdance(), new Moves.Roost() };
	public override int Weight => 180;
	public override int ExpYield => 166;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}