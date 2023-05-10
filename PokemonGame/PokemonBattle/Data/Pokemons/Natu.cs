using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Natu : Pokemon
{
	public override string Name => "Natu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicbounce() };
	public override Stats BaseStats => new Stats(40, 50, 45, 70, 45, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Storedpower() },
		[10] = new List<Move>() { new Moves.Teleport() },
		[15] = new List<Move>() { new Moves.Confuseray() },
		[20] = new List<Move>() { new Moves.Nightshade() },
		[26] = new List<Move>() { new Moves.Psychoshift() },
		[30] = new List<Move>() { new Moves.Powerswap() },
		[35] = new List<Move>() { new Moves.Guardswap(), new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Wish() },
		[45] = new List<Move>() { new Moves.Futuresight() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flash(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Pluck(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uturn(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Drillpeck(), new Moves.Featherdance(), new Moves.Haze(), new Moves.Quickattack(), new Moves.Simplebeam(), new Moves.Suckerpunch(), new Moves.Zenheadbutt() };
	public override int Weight => 20;
	public override int ExpYield => 64;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}