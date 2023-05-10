using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ninjask : Pokemon
{
	public override string Name => "Ninjask";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Speedboost() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(61, 90, 45, 50, 50, 160);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Doubleteam(), new Moves.Screech(), new Moves.Furycutter() },
		[1] = new List<Move>() { new Moves.Doubleteam(), new Moves.Screech(), new Moves.Furycutter(), new Moves.Batonpass(), new Moves.Aerialace(), new Moves.Mudslap(), new Moves.Metalclaw(), new Moves.Dig(), new Moves.Sandattack(), new Moves.Scratch(), new Moves.Harden(), new Moves.Falseswipe() },
		[15] = new List<Move>() { new Moves.Agility() },
		[23] = new List<Move>() { new Moves.Absorb() },
		[29] = new List<Move>() { new Moves.Bugbite() },
		[36] = new List<Move>() { new Moves.Furyswipes() },
		[43] = new List<Move>() { new Moves.Mindreader() },
		[50] = new List<Move>() { new Moves.Slash() },
		[57] = new List<Move>() { new Moves.Swordsdance() },
		[64] = new List<Move>() { new Moves.Xscissor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Batonpass(), new Moves.Bugbuzz(), new Moves.Cut(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Protect(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Xscissor() };
	public override int Weight => 120;
	public override int ExpYield => 160;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}