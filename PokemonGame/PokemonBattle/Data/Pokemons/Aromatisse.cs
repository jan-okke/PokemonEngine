using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aromatisse : Pokemon
{
	public override string Name => "Aromatisse";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Healer() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aromaveil() };
	public override Stats BaseStats => new Stats(101, 72, 72, 99, 89, 29);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Aromaticmist(), new Moves.Healpulse(), new Moves.Fairywind(), new Moves.Sweetscent(), new Moves.Sweetkiss(), new Moves.Echoedvoice() },
		[9] = new List<Move>() { new Moves.Disarmingvoice() },
		[12] = new List<Move>() { new Moves.Aromatherapy() },
		[15] = new List<Move>() { new Moves.Drainingkiss() },
		[18] = new List<Move>() { new Moves.Attract() },
		[21] = new List<Move>() { new Moves.Flail() },
		[24] = new List<Move>() { new Moves.Mistyterrain() },
		[27] = new List<Move>() { new Moves.Psychic() },
		[30] = new List<Move>() { new Moves.Charm() },
		[33] = new List<Move>() { new Moves.Calmmind() },
		[36] = new List<Move>() { new Moves.Moonblast() },
		[39] = new List<Move>() { new Moves.Skillswap() },
		[42] = new List<Move>() { new Moves.Psychup() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Trickroom() };
	public override int Weight => 155;
	public override int ExpYield => 162;
	public override int CatchRate => 140;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}