using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dubwool : Pokemon
{
	public override string Name => "Dubwool";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Fluffy(), new Abilities.Steadfast() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bulletproof() };
	public override Stats BaseStats => new Stats(72, 80, 100, 60, 90, 88);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl(), new Moves.Defensecurl(), new Moves.Copycat() },
		[12] = new List<Move>() { new Moves.Guardsplit() },
		[16] = new List<Move>() { new Moves.Doublekick() },
		[21] = new List<Move>() { new Moves.Headbutt() },
		[27] = new List<Move>() { new Moves.Takedown() },
		[32] = new List<Move>() { new Moves.Guardswap() },
		[38] = new List<Move>() { new Moves.Reversal() },
		[44] = new List<Move>() { new Moves.Cottonguard() },
		[50] = new List<Move>() { new Moves.Doubleedge() },
		[56] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Grassyglide(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Megakick(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Thunderwave(), new Moves.Wildcharge(), new Moves.Zenheadbutt() };
	public override int Weight => 430;
	public override int ExpYield => 172;
	public override int CatchRate => 127;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}