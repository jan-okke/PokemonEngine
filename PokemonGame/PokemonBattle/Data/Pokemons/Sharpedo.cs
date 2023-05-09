using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sharpedo : Pokemon
{
	public override string Name => "Sharpedo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Roughskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Speedboost() };
	public override Stats BaseStats => new Stats(70, 120, 40, 95, 40, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slash() },
		[1] = new List<Move>() { new Moves.Slash(), new Moves.Nightslash(), new Moves.Aquajet(), new Moves.Leer(), new Moves.Poisonfang(), new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Scaryface() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Icefang() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Swagger() },
		[34] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Agility() },
		[46] = new List<Move>() { new Moves.Liquidation() },
		[52] = new List<Move>() { new Moves.Takedown() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override int Weight => 888;
	public override int ExpYield => 161;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}