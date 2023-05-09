using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Silicobra : Pokemon
{
	public override string Name => "Silicobra";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandspit(), new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(52, 57, 75, 35, 50, 46);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Sandattack() },
		[5] = new List<Move>() { new Moves.Minimize() },
		[10] = new List<Move>() { new Moves.Brutalswing() },
		[15] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[25] = new List<Move>() { new Moves.Glare() },
		[30] = new List<Move>() { new Moves.Dig() },
		[35] = new List<Move>() { new Moves.Sandstorm() },
		[40] = new List<Move>() { new Moves.Slam() },
		[45] = new List<Move>() { new Moves.Coil() },
		[50] = new List<Move>() { new Moves.Sandtomb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaleshot(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Dragonrush(), new Moves.Lastresort(), new Moves.Mudslap(), new Moves.Poisontail() };
	public override int Weight => 76;
	public override int ExpYield => 63;
	public override int CatchRate => 255;
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