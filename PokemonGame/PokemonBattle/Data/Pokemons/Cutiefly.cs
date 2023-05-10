using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cutiefly : Pokemon
{
	public override string Name => "Cutiefly";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Honeygather(), new Abilities.Shielddust() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sweetveil() };
	public override Stats BaseStats => new Stats(40, 45, 40, 55, 40, 84);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Fairywind() },
		[6] = new List<Move>() { new Moves.Stunspore() },
		[12] = new List<Move>() { new Moves.Sweetscent() },
		[18] = new List<Move>() { new Moves.Drainingkiss() },
		[24] = new List<Move>() { new Moves.Strugglebug() },
		[30] = new List<Move>() { new Moves.Aromatherapy() },
		[36] = new List<Move>() { new Moves.Switcheroo() },
		[42] = new List<Move>() { new Moves.Dazzlinggleam() },
		[48] = new List<Move>() { new Moves.Bugbuzz() },
		[54] = new List<Move>() { new Moves.Quiverdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Thief(), new Moves.Trick(), new Moves.Uturn(), new Moves.Wonderroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aromaticmist(), new Moves.Moonblast(), new Moves.Stickyweb() };
	public override int Weight => 2;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}