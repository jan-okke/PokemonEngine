using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sinistea : Pokemon
{
	public override string Name => "Sinistea";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Weakarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
	public override Stats BaseStats => new Stats(40, 45, 45, 74, 54, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Withdraw() },
		[6] = new List<Move>() { new Moves.Aromaticmist() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[18] = new List<Move>() { new Moves.Protect() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[30] = new List<Move>() { new Moves.Aromatherapy() },
		[36] = new List<Move>() { new Moves.Gigadrain() },
		[42] = new List<Move>() { new Moves.Nastyplot() },
		[48] = new List<Move>() { new Moves.Shadowball() },
		[54] = new List<Move>() { new Moves.Memento() },
		[60] = new List<Move>() { new Moves.Shellsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Batonpass(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Trick(), new Moves.Willowisp(), new Moves.Wonderroom() };
	public override int Weight => 2;
	public override int ExpYield => 62;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}