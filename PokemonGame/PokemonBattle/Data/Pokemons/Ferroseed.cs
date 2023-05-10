using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ferroseed : Pokemon
{
	public override string Name => "Ferroseed";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironbarbs() };
	public override Stats BaseStats => new Stats(44, 50, 91, 24, 86, 10);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[5] = new List<Move>() { new Moves.Metalclaw() },
		[10] = new List<Move>() { new Moves.Pinmissile() },
		[15] = new List<Move>() { new Moves.Ingrain() },
		[20] = new List<Move>() { new Moves.Flashcannon() },
		[25] = new List<Move>() { new Moves.Ironhead() },
		[30] = new List<Move>() { new Moves.Selfdestruct() },
		[35] = new List<Move>() { new Moves.Irondefense() },
		[41] = new List<Move>() { new Moves.Curse() },
		[45] = new List<Move>() { new Moves.Gyroball() },
		[50] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bulletseed(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigadrain(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderbolt(), new Moves.Thunderwave() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Gravity(), new Moves.Knockoff(), new Moves.Leechseed(), new Moves.Toxic() };
	public override int Weight => 188;
	public override int ExpYield => 61;
	public override int CatchRate => 255;
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