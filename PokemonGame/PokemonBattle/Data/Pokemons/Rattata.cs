using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rattata : Pokemon
{
	public override string Name => "Rattata";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(30, 56, 35, 25, 35, 72);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Quickattack() },
		[7] = new List<Move>() { new Moves.Focusenergy() },
		[10] = new List<Move>() { new Moves.Bite() },
		[13] = new List<Move>() { new Moves.Laserfocus() },
		[16] = new List<Move>() { new Moves.Takedown() },
		[19] = new List<Move>() { new Moves.Assurance() },
		[22] = new List<Move>() { new Moves.Crunch() },
		[25] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Superfang() },
		[31] = new List<Move>() { new Moves.Doubleedge() },
		[34] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bite(), new Moves.Counter(), new Moves.Finalgambit(), new Moves.Flamewheel(), new Moves.Furyswipes(), new Moves.Lastresort(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Screech(), new Moves.Uproar() };
	public override int Weight => 35;
	public override int ExpYield => 51;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}