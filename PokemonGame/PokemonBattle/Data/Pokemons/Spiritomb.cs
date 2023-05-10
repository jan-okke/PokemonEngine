using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Spiritomb : Pokemon
{
	public override string Name => "Spiritomb";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(50, 92, 108, 92, 108, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Nightshade(), new Moves.Confuseray() },
		[5] = new List<Move>() { new Moves.Shadowsneak() },
		[10] = new List<Move>() { new Moves.Spite() },
		[15] = new List<Move>() { new Moves.Payback() },
		[20] = new List<Move>() { new Moves.Nastyplot() },
		[25] = new List<Move>() { new Moves.Hex() },
		[30] = new List<Move>() { new Moves.Memento() },
		[35] = new List<Move>() { new Moves.Suckerpunch() },
		[40] = new List<Move>() { new Moves.Curse() },
		[45] = new List<Move>() { new Moves.Shadowball() },
		[50] = new List<Move>() { new Moves.Darkpulse() },
		[55] = new List<Move>() { new Moves.Hypnosis() },
		[60] = new List<Move>() { new Moves.Dreameater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Willowisp(), new Moves.Wonderroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Destinybond(), new Moves.Disable(), new Moves.Foulplay(), new Moves.Grudge(), new Moves.Imprison(), new Moves.Painsplit(), new Moves.Shadowsneak(), new Moves.Smokescreen() };
	public override int Weight => 1080;
	public override int ExpYield => 170;
	public override int CatchRate => 100;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}