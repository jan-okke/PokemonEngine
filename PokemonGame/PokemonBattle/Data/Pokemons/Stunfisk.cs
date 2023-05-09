using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Stunfisk : Pokemon
{
	public override string Name => "Stunfisk";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static(), new Abilities.Limber() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(109, 66, 84, 81, 99, 32);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Thundershock() },
		[5] = new List<Move>() { new Moves.Endure() },
		[10] = new List<Move>() { new Moves.Mudshot() },
		[15] = new List<Move>() { new Moves.Revenge() },
		[20] = new List<Move>() { new Moves.Charge() },
		[25] = new List<Move>() { new Moves.Suckerpunch() },
		[30] = new List<Move>() { new Moves.Electricterrain() },
		[35] = new List<Move>() { new Moves.Bounce() },
		[40] = new List<Move>() { new Moves.Muddywater() },
		[45] = new List<Move>() { new Moves.Discharge() },
		[50] = new List<Move>() { new Moves.Flail() },
		[55] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Hiddenpower(), new Moves.Lashout(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Curse(), new Moves.Painsplit(), new Moves.Reflecttype(), new Moves.Spark(), new Moves.Spite(), new Moves.Yawn() };
	public override int Weight => 110;
	public override int ExpYield => 165;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}