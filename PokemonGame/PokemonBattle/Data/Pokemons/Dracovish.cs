using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dracovish : Pokemon
{
	public override string Name => "Dracovish";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandrush() };
	public override Stats BaseStats => new Stats(90, 90, 100, 70, 80, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Watergun() },
		[7] = new List<Move>() { new Moves.Protect() },
		[14] = new List<Move>() { new Moves.Brutalswing() },
		[21] = new List<Move>() { new Moves.Ancientpower() },
		[28] = new List<Move>() { new Moves.Bite() },
		[35] = new List<Move>() { new Moves.Dragonbreath() },
		[42] = new List<Move>() { new Moves.Stomp() },
		[49] = new List<Move>() { new Moves.Superfang() },
		[56] = new List<Move>() { new Moves.Crunch() },
		[63] = new List<Move>() { new Moves.Fishiousrend() },
		[70] = new List<Move>() { new Moves.Dragonpulse() },
		[77] = new List<Move>() { new Moves.Dragonrush() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dive(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Ironhead(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override int Weight => 2150;
	public override int ExpYield => 177;
	public override int CatchRate => 45;
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