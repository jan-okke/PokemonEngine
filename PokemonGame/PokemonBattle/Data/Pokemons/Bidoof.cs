using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bidoof : Pokemon
{
	public override string Name => "Bidoof";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Simple(), new Abilities.Unaware() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
	public override Stats BaseStats => new Stats(59, 45, 40, 35, 40, 31);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[5] = new List<Move>() { new Moves.Defensecurl() },
		[9] = new List<Move>() { new Moves.Rollout() },
		[13] = new List<Move>() { new Moves.Headbutt() },
		[17] = new List<Move>() { new Moves.Taunt() },
		[21] = new List<Move>() { new Moves.Yawn() },
		[25] = new List<Move>() { new Moves.Crunch() },
		[29] = new List<Move>() { new Moves.Takedown() },
		[33] = new List<Move>() { new Moves.Superfang() },
		[37] = new List<Move>() { new Moves.Swordsdance() },
		[41] = new List<Move>() { new Moves.Amnesia() },
		[45] = new List<Move>() { new Moves.Superpower() },
		[49] = new List<Move>() { new Moves.Curse() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Defensecurl(), new Moves.Doubleedge(), new Moves.Furyswipes(), new Moves.Quickattack(), new Moves.Rollout(), new Moves.Skullbash() };
	public override int Weight => 200;
	public override int ExpYield => 50;
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