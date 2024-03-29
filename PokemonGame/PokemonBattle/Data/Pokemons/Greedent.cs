using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Greedent : Pokemon
{
	public override string Name => "Greedent";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cheekpouch() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
	public override Stats BaseStats => new Stats(120, 95, 95, 55, 75, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Covet() },
		[1] = new List<Move>() { new Moves.Covet(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Bite(), new Moves.Stuffcheeks() },
		[15] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[20] = new List<Move>() { new Moves.Bodyslam() },
		[27] = new List<Move>() { new Moves.Rest() },
		[34] = new List<Move>() { new Moves.Counter() },
		[41] = new List<Move>() { new Moves.Bulletseed() },
		[48] = new List<Move>() { new Moves.Superfang() },
		[55] = new List<Move>() { new Moves.Belch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulletseed(), new Moves.Crunch(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Uproar(), new Moves.Wildcharge() };
	public override int Weight => 60;
	public override int ExpYield => 161;
	public override int CatchRate => 90;
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