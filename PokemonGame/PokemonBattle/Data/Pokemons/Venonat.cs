using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Venonat : Pokemon
{
	public override string Name => "Venonat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Compoundeyes(), new Abilities.Tintedlens() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
	public override Stats BaseStats => new Stats(60, 55, 50, 40, 55, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Disable(), new Moves.Strugglebug() },
		[5] = new List<Move>() { new Moves.Supersonic() },
		[11] = new List<Move>() { new Moves.Confusion() },
		[13] = new List<Move>() { new Moves.Poisonpowder() },
		[17] = new List<Move>() { new Moves.Psybeam() },
		[23] = new List<Move>() { new Moves.Stunspore() },
		[25] = new List<Move>() { new Moves.Megadrain() },
		[29] = new List<Move>() { new Moves.Sleeppowder() },
		[35] = new List<Move>() { new Moves.Leechlife() },
		[37] = new List<Move>() { new Moves.Zenheadbutt() },
		[41] = new List<Move>() { new Moves.Poisonfang() },
		[47] = new List<Move>() { new Moves.Psychic() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbite(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Leechlife(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Batonpass(), new Moves.Bugbite(), new Moves.Morningsun(), new Moves.Ragepowder(), new Moves.Screech(), new Moves.Toxicspikes() };
	public override int Weight => 300;
	public override int ExpYield => 61;
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