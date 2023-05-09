using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pansage : Pokemon
{
	public override string Name => "Pansage";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Gluttony() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overgrow() };
	public override Stats BaseStats => new Stats(50, 53, 48, 53, 48, 64);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Playnice() },
		[4] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Lick() },
		[10] = new List<Move>() { new Moves.Vinewhip() },
		[13] = new List<Move>() { new Moves.Furyswipes() },
		[16] = new List<Move>() { new Moves.Leechseed() },
		[19] = new List<Move>() { new Moves.Bite() },
		[22] = new List<Move>() { new Moves.Seedbomb() },
		[25] = new List<Move>() { new Moves.Torment() },
		[28] = new List<Move>() { new Moves.Fling() },
		[31] = new List<Move>() { new Moves.Acrobatics() },
		[34] = new List<Move>() { new Moves.Grassknot() },
		[37] = new List<Move>() { new Moves.Recycle() },
		[40] = new List<Move>() { new Moves.Naturalgift() },
		[43] = new List<Move>() { new Moves.Crunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Workup(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Bulletseed(), new Moves.Covet(), new Moves.Disarmingvoice(), new Moves.Grasswhistle(), new Moves.Leafstorm(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Nastyplot(), new Moves.Roleplay(), new Moves.Spikyshield(), new Moves.Tickle() };
	public override int Weight => 105;
	public override int ExpYield => 63;
	public override int CatchRate => 190;
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