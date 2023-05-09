using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dugtrio : Pokemon
{
	public override string Name => "Dugtrio";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil(), new Abilities.Arenatrap() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
	public override Stats BaseStats => new Stats(35, 100, 50, 50, 70, 120);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Sandtomb() },
		[1] = new List<Move>() { new Moves.Sandtomb(), new Moves.Nightslash(), new Moves.Triattack(), new Moves.Sandattack(), new Moves.Scratch(), new Moves.Growl(), new Moves.Astonish() },
		[12] = new List<Move>() { new Moves.Mudslap() },
		[16] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Suckerpunch() },
		[24] = new List<Move>() { new Moves.Slash() },
		[30] = new List<Move>() { new Moves.Sandstorm() },
		[36] = new List<Move>() { new Moves.Dig() },
		[42] = new List<Move>() { new Moves.Earthpower() },
		[48] = new List<Move>() { new Moves.Earthquake() },
		[54] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Triattack(), new Moves.Uproar(), new Moves.Workup() };
	public override int Weight => 333;
	public override int ExpYield => 149;
	public override int CatchRate => 50;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}