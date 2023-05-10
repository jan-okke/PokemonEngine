using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Corviknight : Pokemon
{
	public override string Name => "Corviknight";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure(), new Abilities.Unnerve() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Mirrorarmor() };
	public override Stats BaseStats => new Stats(98, 87, 105, 53, 85, 67);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Steelwing() },
		[1] = new List<Move>() { new Moves.Steelwing(), new Moves.Irondefense(), new Moves.Metalsound(), new Moves.Peck(), new Moves.Leer(), new Moves.Powertrip(), new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Furyattack() },
		[16] = new List<Move>() { new Moves.Pluck() },
		[22] = new List<Move>() { new Moves.Taunt() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[34] = new List<Move>() { new Moves.Drillpeck() },
		[42] = new List<Move>() { new Moves.Swagger() },
		[50] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bravebird(), new Moves.Bulkup(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 750;
	public override int ExpYield => 248;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 3,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}