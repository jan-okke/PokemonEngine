using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Barboach : Pokemon
{
	public override string Name => "Barboach";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Anticipation() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(50, 48, 43, 46, 41, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Rest(), new Moves.Snore() },
		[12] = new List<Move>() { new Moves.Waterpulse() },
		[18] = new List<Move>() { new Moves.Amnesia() },
		[24] = new List<Move>() { new Moves.Aquatail() },
		[31] = new List<Move>() { new Moves.Muddywater() },
		[36] = new List<Move>() { new Moves.Earthquake() },
		[42] = new List<Move>() { new Moves.Futuresight() },
		[48] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Dragondance(), new Moves.Earthpower(), new Moves.Flail(), new Moves.Hydropump(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Spark(), new Moves.Takedown(), new Moves.Thrash(), new Moves.Whirlpool() };
	public override int Weight => 19;
	public override int ExpYield => 58;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}