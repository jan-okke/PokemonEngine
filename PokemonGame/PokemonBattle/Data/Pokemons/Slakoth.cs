using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Slakoth : Pokemon
{
	public override string Name => "Slakoth";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Truant() };
	public override Stats BaseStats => new Stats(60, 60, 60, 35, 35, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Yawn() },
		[6] = new List<Move>() { new Moves.Encore() },
		[9] = new List<Move>() { new Moves.Slackoff() },
		[14] = new List<Move>() { new Moves.Rest() },
		[17] = new List<Move>() { new Moves.Amnesia() },
		[22] = new List<Move>() { new Moves.Covet() },
		[25] = new List<Move>() { new Moves.Headbutt() },
		[30] = new List<Move>() { new Moves.Counter() },
		[33] = new List<Move>() { new Moves.Flail() },
		[38] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Waterpulse(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Bodyslam(), new Moves.Crushclaw(), new Moves.Curse(), new Moves.Hammerarm(), new Moves.Nightslash(), new Moves.Slash(), new Moves.Snore(), new Moves.Tickle() };
	public override int Weight => 240;
	public override int ExpYield => 56;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}