using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Amoonguss : Pokemon
{
	public override string Name => "Amoonguss";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(114, 85, 70, 85, 80, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Astonish(), new Moves.Growth(), new Moves.Stunspore() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Synthesis() },
		[20] = new List<Move>() { new Moves.Clearsmog() },
		[24] = new List<Move>() { new Moves.Sweetscent() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Ingrain() },
		[36] = new List<Move>() { new Moves.Toxic() },
		[42] = new List<Move>() { new Moves.Ragepowder() },
		[48] = new List<Move>() { new Moves.Solarbeam() },
		[54] = new List<Move>() { new Moves.Spore() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyterrain(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Payback(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Venoshock() };
	public override int Weight => 105;
	public override int ExpYield => 162;
	public override int CatchRate => 75;
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