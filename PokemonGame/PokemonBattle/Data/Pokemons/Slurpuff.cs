using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Slurpuff : Pokemon
{
	public override string Name => "Slurpuff";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sweetveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unburden() };
	public override Stats BaseStats => new Stats(82, 80, 86, 85, 75, 72);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Sweetscent(), new Moves.Playnice(), new Moves.Fairywind() },
		[9] = new List<Move>() { new Moves.Aromatherapy() },
		[12] = new List<Move>() { new Moves.Drainingkiss() },
		[15] = new List<Move>() { new Moves.Faketears() },
		[18] = new List<Move>() { new Moves.Round() },
		[21] = new List<Move>() { new Moves.Stringshot() },
		[24] = new List<Move>() { new Moves.Cottonspore() },
		[27] = new List<Move>() { new Moves.Energyball() },
		[30] = new List<Move>() { new Moves.Wish() },
		[33] = new List<Move>() { new Moves.Playrough() },
		[36] = new List<Move>() { new Moves.Cottonguard() },
		[39] = new List<Move>() { new Moves.Endeavor() },
		[42] = new List<Move>() { new Moves.Stickyweb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt() };
	public override int Weight => 50;
	public override int ExpYield => 168;
	public override int CatchRate => 140;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}