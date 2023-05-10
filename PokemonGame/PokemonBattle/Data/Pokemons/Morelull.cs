using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Morelull : Pokemon
{
	public override string Name => "Morelull";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Effectspore() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(40, 35, 55, 65, 75, 15);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Astonish() },
		[4] = new List<Move>() { new Moves.Confuseray() },
		[8] = new List<Move>() { new Moves.Ingrain() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Moonlight() },
		[25] = new List<Move>() { new Moves.Strengthsap() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[32] = new List<Move>() { new Moves.Dazzlinggleam() },
		[36] = new List<Move>() { new Moves.Spore() },
		[40] = new List<Move>() { new Moves.Moonblast() },
		[44] = new List<Move>() { new Moves.Dreameater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderwave(), new Moves.Wonderroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Growth(), new Moves.Leechseed(), new Moves.Poisonpowder(), new Moves.Stunspore() };
	public override int Weight => 15;
	public override int ExpYield => 57;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}