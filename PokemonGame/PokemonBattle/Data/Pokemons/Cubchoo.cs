using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cubchoo : Pokemon
{
	public override string Name => "Cubchoo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Snowcloak(), new Abilities.Slushrush() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(55, 70, 40, 60, 40, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Growl() },
		[3] = new List<Move>() { new Moves.Endure() },
		[6] = new List<Move>() { new Moves.Furyswipes() },
		[9] = new List<Move>() { new Moves.Icywind() },
		[12] = new List<Move>() { new Moves.Playnice() },
		[15] = new List<Move>() { new Moves.Brine() },
		[18] = new List<Move>() { new Moves.Frostbreath() },
		[21] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Flail() },
		[27] = new List<Move>() { new Moves.Charm() },
		[30] = new List<Move>() { new Moves.Hail() },
		[33] = new List<Move>() { new Moves.Thrash() },
		[36] = new List<Move>() { new Moves.Rest() },
		[39] = new List<Move>() { new Moves.Blizzard() },
		[42] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Charm(), new Moves.Dig(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Focuspunch(), new Moves.Nightslash(), new Moves.Yawn() };
	public override int Weight => 85;
	public override int ExpYield => 61;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}