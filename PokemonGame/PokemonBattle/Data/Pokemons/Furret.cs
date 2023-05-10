using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Furret : Pokemon
{
	public override string Name => "Furret";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Keeneye() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
	public override Stats BaseStats => new Stats(85, 76, 64, 45, 55, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Agility() },
		[1] = new List<Move>() { new Moves.Agility(), new Moves.Coil(), new Moves.Scratch(), new Moves.Defensecurl(), new Moves.Quickattack() },
		[4] = new List<Move>() { new Moves.Defensecurl() },
		[7] = new List<Move>() { new Moves.Quickattack() },
		[13] = new List<Move>() { new Moves.Furyswipes() },
		[17] = new List<Move>() { new Moves.Helpinghand() },
		[21] = new List<Move>() { new Moves.Followme() },
		[28] = new List<Move>() { new Moves.Slam() },
		[32] = new List<Move>() { new Moves.Rest() },
		[36] = new List<Move>() { new Moves.Suckerpunch() },
		[42] = new List<Move>() { new Moves.Amnesia() },
		[46] = new List<Move>() { new Moves.Batonpass() },
		[50] = new List<Move>() { new Moves.Reversal() },
		[56] = new List<Move>() { new Moves.Hypervoice() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Trick(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 325;
	public override int ExpYield => 145;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}