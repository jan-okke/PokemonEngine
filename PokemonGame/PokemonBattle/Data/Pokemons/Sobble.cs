using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sobble : Pokemon
{
	public override string Name => "Sobble";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
	public override Stats BaseStats => new Stats(50, 40, 40, 70, 40, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Growl() },
		[6] = new List<Move>() { new Moves.Watergun() },
		[8] = new List<Move>() { new Moves.Bind() },
		[12] = new List<Move>() { new Moves.Waterpulse() },
		[17] = new List<Move>() { new Moves.Tearfullook() },
		[20] = new List<Move>() { new Moves.Suckerpunch() },
		[24] = new List<Move>() { new Moves.Uturn() },
		[28] = new List<Move>() { new Moves.Liquidation() },
		[32] = new List<Move>() { new Moves.Soak() },
		[36] = new List<Move>() { new Moves.Raindance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bounce(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Uturn(), new Moves.Waterpledge(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Aquaring(), new Moves.Doubleteam(), new Moves.Fellstinger(), new Moves.Haze(), new Moves.Iceshard(), new Moves.Mist() };
	public override int Weight => 40;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 1
	};
}