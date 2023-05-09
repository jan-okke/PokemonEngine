using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Murkrow : Pokemon
{
	public override string Name => "Murkrow";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Superluck() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
	public override Stats BaseStats => new Stats(60, 85, 42, 85, 42, 91);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Astonish() },
		[5] = new List<Move>() { new Moves.Gust() },
		[11] = new List<Move>() { new Moves.Haze() },
		[15] = new List<Move>() { new Moves.Wingattack() },
		[21] = new List<Move>() { new Moves.Nightshade() },
		[25] = new List<Move>() { new Moves.Assurance() },
		[31] = new List<Move>() { new Moves.Taunt() },
		[35] = new List<Move>() { new Moves.Aircutter() },
		[41] = new List<Move>() { new Moves.Meanlook() },
		[45] = new List<Move>() { new Moves.Foulplay() },
		[50] = new List<Move>() { new Moves.Tailwind() },
		[55] = new List<Move>() { new Moves.Suckerpunch() },
		[61] = new List<Move>() { new Moves.Torment() },
		[65] = new List<Move>() { new Moves.Quash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Quash(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Bravebird(), new Moves.Confuseray(), new Moves.Drillpeck(), new Moves.Featherdance(), new Moves.Flatter(), new Moves.Perishsong(), new Moves.Psychoshift(), new Moves.Screech(), new Moves.Skyattack(), new Moves.Whirlwind(), new Moves.Wingattack() };
	public override int Weight => 21;
	public override int ExpYield => 81;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}