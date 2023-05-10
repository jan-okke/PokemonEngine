using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hatenna : Pokemon
{
	public override string Name => "Hatenna";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Healer(), new Abilities.Anticipation() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicbounce() };
	public override Stats BaseStats => new Stats(42, 30, 45, 56, 53, 39);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Playnice() },
		[5] = new List<Move>() { new Moves.Lifedew() },
		[10] = new List<Move>() { new Moves.Disarmingvoice() },
		[15] = new List<Move>() { new Moves.Aromatherapy() },
		[20] = new List<Move>() { new Moves.Psybeam() },
		[25] = new List<Move>() { new Moves.Healpulse() },
		[30] = new List<Move>() { new Moves.Dazzlinggleam() },
		[35] = new List<Move>() { new Moves.Calmmind() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[45] = new List<Move>() { new Moves.Healingwish() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thunderwave() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Aromaticmist(), new Moves.Nuzzle(), new Moves.Quash() };
	public override int Weight => 34;
	public override int ExpYield => 53;
	public override int CatchRate => 235;
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