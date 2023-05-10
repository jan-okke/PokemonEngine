using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vullaby : Pokemon
{
	public override string Name => "Vullaby";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Bigpecks(), new Abilities.Overcoat() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(70, 55, 75, 45, 65, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Flatter() },
		[12] = new List<Move>() { new Moves.Pluck() },
		[18] = new List<Move>() { new Moves.Tailwind() },
		[24] = new List<Move>() { new Moves.Knockoff() },
		[30] = new List<Move>() { new Moves.Irondefense() },
		[36] = new List<Move>() { new Moves.Whirlwind() },
		[42] = new List<Move>() { new Moves.Airslash() },
		[48] = new List<Move>() { new Moves.Darkpulse() },
		[54] = new List<Move>() { new Moves.Nastyplot() },
		[60] = new List<Move>() { new Moves.Defog() },
		[66] = new List<Move>() { new Moves.Attract() },
		[72] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Darkpulse(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fly(), new Moves.Foulplay(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Meanlook(), new Moves.Roost(), new Moves.Toxic() };
	public override int Weight => 90;
	public override int ExpYield => 74;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}