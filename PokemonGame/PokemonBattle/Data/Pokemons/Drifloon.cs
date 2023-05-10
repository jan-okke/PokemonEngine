using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Drifloon : Pokemon
{
	public override string Name => "Drifloon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Aftermath(), new Abilities.Unburden() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flareboost() };
	public override Stats BaseStats => new Stats(90, 50, 34, 60, 44, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Minimize(), new Moves.Astonish() },
		[4] = new List<Move>() { new Moves.Gust() },
		[8] = new List<Move>() { new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Payback() },
		[16] = new List<Move>() { new Moves.Hex() },
		[20] = new List<Move>() { new Moves.Shadowball() },
		[24] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[29] = new List<Move>() { new Moves.Selfdestruct() },
		[32] = new List<Move>() { new Moves.Destinybond() },
		[36] = new List<Move>() { new Moves.Batonpass() },
		[40] = new List<Move>() { new Moves.Tailwind() },
		[44] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Clearsmog(), new Moves.Destinybond(), new Moves.Disable(), new Moves.Haze(), new Moves.Hypnosis(), new Moves.Memento(), new Moves.Tailwind(), new Moves.Weatherball() };
	public override int Weight => 12;
	public override int ExpYield => 70;
	public override int CatchRate => 125;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}