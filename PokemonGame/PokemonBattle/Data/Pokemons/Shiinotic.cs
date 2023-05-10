using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shiinotic : Pokemon
{
	public override string Name => "Shiinotic";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Effectspore() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(60, 45, 80, 90, 100, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Astonish(), new Moves.Confuseray(), new Moves.Ingrain() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Sleeppowder() },
		[20] = new List<Move>() { new Moves.Moonlight() },
		[27] = new List<Move>() { new Moves.Strengthsap() },
		[32] = new List<Move>() { new Moves.Gigadrain() },
		[38] = new List<Move>() { new Moves.Dazzlinggleam() },
		[44] = new List<Move>() { new Moves.Spore() },
		[50] = new List<Move>() { new Moves.Moonblast() },
		[56] = new List<Move>() { new Moves.Dreameater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderwave(), new Moves.Weatherball(), new Moves.Wonderroom() };
	public override int Weight => 115;
	public override int ExpYield => 142;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}