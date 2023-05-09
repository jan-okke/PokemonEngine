using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Grimmsnarl : Pokemon
{
	public override string Name => "Grimmsnarl";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
	public override Stats BaseStats => new Stats(95, 120, 65, 95, 75, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Spiritbreak() },
		[1] = new List<Move>() { new Moves.Spiritbreak(), new Moves.Falsesurrender(), new Moves.Bulkup(), new Moves.Poweruppunch(), new Moves.Fakeout(), new Moves.Confide(), new Moves.Bite(), new Moves.Flatter() },
		[12] = new List<Move>() { new Moves.Faketears() },
		[16] = new List<Move>() { new Moves.Assurance() },
		[20] = new List<Move>() { new Moves.Swagger() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Torment() },
		[35] = new List<Move>() { new Moves.Darkpulse() },
		[40] = new List<Move>() { new Moves.Nastyplot() },
		[48] = new List<Move>() { new Moves.Playrough() },
		[56] = new List<Move>() { new Moves.Foulplay() },
		[64] = new List<Move>() { new Moves.Hammerarm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Burningjealousy(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Lashout(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uproar(), new Moves.Wonderroom() };
	public override int Weight => 610;
	public override int ExpYield => 255;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}