using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Klefki : Pokemon
{
	public override string Name => "Klefki";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magician() };
	public override Stats BaseStats => new Stats(57, 80, 91, 80, 87, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Fairylock(), new Moves.Astonish() },
		[4] = new List<Move>() { new Moves.Tackle() },
		[8] = new List<Move>() { new Moves.Fairywind() },
		[12] = new List<Move>() { new Moves.Torment() },
		[16] = new List<Move>() { new Moves.Craftyshield() },
		[20] = new List<Move>() { new Moves.Metalsound() },
		[24] = new List<Move>() { new Moves.Drainingkiss() },
		[28] = new List<Move>() { new Moves.Recycle() },
		[32] = new List<Move>() { new Moves.Imprison() },
		[36] = new List<Move>() { new Moves.Flashcannon() },
		[40] = new List<Move>() { new Moves.Playrough() },
		[44] = new List<Move>() { new Moves.Magicroom() },
		[48] = new List<Move>() { new Moves.Foulplay() },
		[52] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Steelbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Thunderwave() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Magnetrise(), new Moves.Switcheroo() };
	public override int Weight => 30;
	public override int ExpYield => 165;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}