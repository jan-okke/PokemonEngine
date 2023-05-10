using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ferrothorn : Pokemon
{
	public override string Name => "Ferrothorn";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironbarbs() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Anticipation() };
	public override Stats BaseStats => new Stats(74, 94, 131, 54, 116, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Powerwhip() },
		[1] = new List<Move>() { new Moves.Powerwhip(), new Moves.Tackle(), new Moves.Harden(), new Moves.Metalclaw(), new Moves.Pinmissile() },
		[15] = new List<Move>() { new Moves.Ingrain() },
		[20] = new List<Move>() { new Moves.Flashcannon() },
		[25] = new List<Move>() { new Moves.Ironhead() },
		[30] = new List<Move>() { new Moves.Selfdestruct() },
		[35] = new List<Move>() { new Moves.Irondefense() },
		[43] = new List<Move>() { new Moves.Curse() },
		[49] = new List<Move>() { new Moves.Gyroball() },
		[56] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave() };
	public override int Weight => 1100;
	public override int ExpYield => 171;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}