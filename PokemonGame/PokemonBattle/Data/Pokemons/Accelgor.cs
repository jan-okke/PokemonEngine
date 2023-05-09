using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Accelgor : Pokemon
{
	public override string Name => "Accelgor";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hydration(), new Abilities.Stickyhold() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unburden() };
	public override Stats BaseStats => new Stats(80, 70, 40, 100, 60, 145);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watershuriken(), new Moves.Acid(), new Moves.Curse(), new Moves.Yawn(), new Moves.Acidarmor(), new Moves.Guardswap(), new Moves.Bodyslam(), new Moves.Absorb(), new Moves.Doubleteam(), new Moves.Acidspray(), new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Strugglebug() },
		[20] = new List<Move>() { new Moves.Swift() },
		[24] = new List<Move>() { new Moves.Agility() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Powerswap() },
		[36] = new List<Move>() { new Moves.Uturn() },
		[40] = new List<Move>() { new Moves.Recover() },
		[44] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Finalgambit() },
		[52] = new List<Move>() { new Moves.Toxic() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bugbuzz(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Mudshot(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Swift(), new Moves.Toxicspikes(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Venoshock() };
	public override int Weight => 253;
	public override int ExpYield => 173;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}