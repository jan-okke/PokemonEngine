using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gible : Pokemon
{
	public override string Name => "Gible";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Roughskin() };
	public override Stats BaseStats => new Stats(58, 70, 45, 40, 45, 42);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sandtomb(), new Moves.Tackle() },
		[6] = new List<Move>() { new Moves.Sandattack() },
		[12] = new List<Move>() { new Moves.Dragonbreath() },
		[18] = new List<Move>() { new Moves.Bulldoze() },
		[25] = new List<Move>() { new Moves.Bite() },
		[30] = new List<Move>() { new Moves.Slash() },
		[36] = new List<Move>() { new Moves.Dragonclaw() },
		[42] = new List<Move>() { new Moves.Dig() },
		[48] = new List<Move>() { new Moves.Sandstorm() },
		[54] = new List<Move>() { new Moves.Takedown() },
		[60] = new List<Move>() { new Moves.Dragonrush() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Doubleedge(), new Moves.Dragonbreath(), new Moves.Ironhead(), new Moves.Metalclaw(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Thrash(), new Moves.Twister() };
	public override int Weight => 205;
	public override int ExpYield => 60;
	public override int CatchRate => 45;
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