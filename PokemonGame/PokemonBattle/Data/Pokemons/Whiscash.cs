using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Whiscash : Pokemon
{
	public override string Name => "Whiscash";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Anticipation() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
	public override Stats BaseStats => new Stats(110, 78, 73, 76, 71, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thrash() },
		[1] = new List<Move>() { new Moves.Thrash(), new Moves.Belch(), new Moves.Zenheadbutt(), new Moves.Tickle(), new Moves.Mudslap(), new Moves.Watergun(), new Moves.Rest(), new Moves.Snore() },
		[12] = new List<Move>() { new Moves.Waterpulse() },
		[18] = new List<Move>() { new Moves.Amnesia() },
		[24] = new List<Move>() { new Moves.Aquatail() },
		[33] = new List<Move>() { new Moves.Muddywater() },
		[40] = new List<Move>() { new Moves.Earthquake() },
		[48] = new List<Move>() { new Moves.Futuresight() },
		[56] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override int Weight => 236;
	public override int ExpYield => 164;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}