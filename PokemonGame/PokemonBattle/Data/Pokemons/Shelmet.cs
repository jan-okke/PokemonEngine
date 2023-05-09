using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shelmet : Pokemon
{
	public override string Name => "Shelmet";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hydration(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(50, 40, 85, 40, 65, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Protect() },
		[4] = new List<Move>() { new Moves.Acid() },
		[8] = new List<Move>() { new Moves.Curse() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Strugglebug() },
		[20] = new List<Move>() { new Moves.Yawn() },
		[24] = new List<Move>() { new Moves.Acidarmor() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Guardswap() },
		[36] = new List<Move>() { new Moves.Bodyslam() },
		[40] = new List<Move>() { new Moves.Recover() },
		[44] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Finalgambit() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bugbuzz(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Toxicspikes(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Feint(), new Moves.Guardsplit(), new Moves.Mindreader() };
	public override int Weight => 77;
	public override int ExpYield => 61;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}