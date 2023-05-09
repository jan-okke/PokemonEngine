using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sandaconda : Pokemon
{
	public override string Name => "Sandaconda";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandspit(), new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(72, 107, 125, 65, 70, 71);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Skullbash(), new Moves.Wrap(), new Moves.Sandattack(), new Moves.Minimize(), new Moves.Brutalswing() },
		[15] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[25] = new List<Move>() { new Moves.Glare() },
		[30] = new List<Move>() { new Moves.Dig() },
		[35] = new List<Move>() { new Moves.Sandstorm() },
		[42] = new List<Move>() { new Moves.Slam() },
		[49] = new List<Move>() { new Moves.Coil() },
		[51] = new List<Move>() { new Moves.Sandtomb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaleshot(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Zenheadbutt() };
	public override int Weight => 655;
	public override int ExpYield => 179;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}