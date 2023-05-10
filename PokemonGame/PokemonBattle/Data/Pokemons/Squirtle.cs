using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Squirtle : Pokemon
{
	public override string Name => "Squirtle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(44, 48, 65, 50, 64, 43);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[3] = new List<Move>() { new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Withdraw() },
		[9] = new List<Move>() { new Moves.Rapidspin() },
		[12] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Waterpulse() },
		[18] = new List<Move>() { new Moves.Protect() },
		[21] = new List<Move>() { new Moves.Raindance() },
		[24] = new List<Move>() { new Moves.Aquatail() },
		[27] = new List<Move>() { new Moves.Shellsmash() },
		[30] = new List<Move>() { new Moves.Irondefense() },
		[33] = new List<Move>() { new Moves.Hydropump() },
		[36] = new List<Move>() { new Moves.Skullbash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Flipturn(), new Moves.Focuspunch(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Aquaring(), new Moves.Aurasphere(), new Moves.Fakeout(), new Moves.Flail(), new Moves.Haze(), new Moves.Lifedew(), new Moves.Mirrorcoat(), new Moves.Mist(), new Moves.Muddywater(), new Moves.Waterspout(), new Moves.Yawn() };
	public override int Weight => 90;
	public override int ExpYield => 63;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}