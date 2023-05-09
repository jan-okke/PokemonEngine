using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Raticate : Pokemon
{
	public override string Name => "Raticate";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(55, 81, 60, 50, 70, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Scaryface() },
		[1] = new List<Move>() { new Moves.Scaryface(), new Moves.Swordsdance(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Quickattack(), new Moves.Focusenergy() },
		[4] = new List<Move>() { new Moves.Quickattack() },
		[7] = new List<Move>() { new Moves.Focusenergy() },
		[10] = new List<Move>() { new Moves.Bite() },
		[13] = new List<Move>() { new Moves.Laserfocus() },
		[16] = new List<Move>() { new Moves.Takedown() },
		[19] = new List<Move>() { new Moves.Assurance() },
		[24] = new List<Move>() { new Moves.Crunch() },
		[29] = new List<Move>() { new Moves.Suckerpunch() },
		[34] = new List<Move>() { new Moves.Superfang() },
		[39] = new List<Move>() { new Moves.Doubleedge() },
		[44] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 185;
	public override int ExpYield => 145;
	public override int CatchRate => 127;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}