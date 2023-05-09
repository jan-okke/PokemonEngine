using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Alcremie : Pokemon
{
	public override string Name => "Alcremie";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sweetveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aromaveil() };
	public override Stats BaseStats => new Stats(65, 60, 75, 110, 121, 64);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Decorate() },
		[1] = new List<Move>() { new Moves.Decorate(), new Moves.Tackle(), new Moves.Aromaticmist(), new Moves.Sweetkiss(), new Moves.Sweetscent() },
		[15] = new List<Move>() { new Moves.Drainingkiss() },
		[20] = new List<Move>() { new Moves.Aromatherapy() },
		[25] = new List<Move>() { new Moves.Attract() },
		[30] = new List<Move>() { new Moves.Acidarmor() },
		[35] = new List<Move>() { new Moves.Dazzlinggleam() },
		[40] = new List<Move>() { new Moves.Recover() },
		[45] = new List<Move>() { new Moves.Mistyterrain() },
		[50] = new List<Move>() { new Moves.Entrainment() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Triattack(), new Moves.Wonderroom() };
	public override int Weight => 5;
	public override int ExpYield => 173;
	public override int CatchRate => 100;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}