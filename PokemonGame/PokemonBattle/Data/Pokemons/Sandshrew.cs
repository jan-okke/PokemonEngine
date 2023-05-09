using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sandshrew : Pokemon
{
	public override string Name => "Sandshrew";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandrush() };
	public override Stats BaseStats => new Stats(50, 75, 85, 20, 30, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Defensecurl() },
		[3] = new List<Move>() { new Moves.Poisonsting() },
		[6] = new List<Move>() { new Moves.Sandattack() },
		[9] = new List<Move>() { new Moves.Rollout() },
		[12] = new List<Move>() { new Moves.Furycutter() },
		[15] = new List<Move>() { new Moves.Rapidspin() },
		[18] = new List<Move>() { new Moves.Bulldoze() },
		[21] = new List<Move>() { new Moves.Swift() },
		[24] = new List<Move>() { new Moves.Furyswipes() },
		[27] = new List<Move>() { new Moves.Agility() },
		[30] = new List<Move>() { new Moves.Slash() },
		[33] = new List<Move>() { new Moves.Dig() },
		[36] = new List<Move>() { new Moves.Gyroball() },
		[39] = new List<Move>() { new Moves.Swordsdance() },
		[42] = new List<Move>() { new Moves.Sandstorm() },
		[45] = new List<Move>() { new Moves.Earthquake() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Workup(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Crushclaw(), new Moves.Flail(), new Moves.Honeclaws(), new Moves.Metalclaw(), new Moves.Mudshot(), new Moves.Mudslap(), new Moves.Nightslash(), new Moves.Rapidspin() };
	public override int Weight => 120;
	public override int ExpYield => 60;
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