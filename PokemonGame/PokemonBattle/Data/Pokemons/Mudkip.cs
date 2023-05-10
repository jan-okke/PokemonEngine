using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mudkip : Pokemon
{
	public override string Name => "Mudkip";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
	public override Stats BaseStats => new Stats(50, 70, 50, 50, 50, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[3] = new List<Move>() { new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Rocksmash() },
		[9] = new List<Move>() { new Moves.Rockthrow() },
		[12] = new List<Move>() { new Moves.Protect() },
		[15] = new List<Move>() { new Moves.Supersonic() },
		[18] = new List<Move>() { new Moves.Waterpulse() },
		[21] = new List<Move>() { new Moves.Rockslide() },
		[24] = new List<Move>() { new Moves.Takedown() },
		[27] = new List<Move>() { new Moves.Amnesia() },
		[30] = new List<Move>() { new Moves.Surf() },
		[33] = new List<Move>() { new Moves.Screech() },
		[36] = new List<Move>() { new Moves.Endeavor() },
		[39] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Bite(), new Moves.Counter(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Mirrorcoat(), new Moves.Mudslap(), new Moves.Sludge(), new Moves.Stomp(), new Moves.Uproar(), new Moves.Whirlpool(), new Moves.Wideguard(), new Moves.Yawn() };
	public override int Weight => 76;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}