using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sandslash : Pokemon
{
	public override string Name => "Sandslash";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandrush() };
	public override Stats BaseStats => new Stats(75, 100, 110, 45, 55, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Crushclaw(), new Moves.Scratch(), new Moves.Defensecurl(), new Moves.Poisonsting(), new Moves.Sandattack() },
		[9] = new List<Move>() { new Moves.Rollout() },
		[12] = new List<Move>() { new Moves.Furycutter() },
		[15] = new List<Move>() { new Moves.Rapidspin() },
		[18] = new List<Move>() { new Moves.Bulldoze() },
		[21] = new List<Move>() { new Moves.Swift() },
		[26] = new List<Move>() { new Moves.Furyswipes() },
		[31] = new List<Move>() { new Moves.Sandtomb() },
		[36] = new List<Move>() { new Moves.Slash() },
		[41] = new List<Move>() { new Moves.Dig() },
		[46] = new List<Move>() { new Moves.Gyroball() },
		[51] = new List<Move>() { new Moves.Swordsdance() },
		[56] = new List<Move>() { new Moves.Sandstorm() },
		[61] = new List<Move>() { new Moves.Earthquake() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Mudshot(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Workup(), new Moves.Xscissor() };
	public override int Weight => 295;
	public override int ExpYield => 158;
	public override int CatchRate => 90;
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