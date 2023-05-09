using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Snivy : Pokemon
{
	public override string Name => "Snivy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
	public override Stats BaseStats => new Stats(45, 45, 55, 45, 55, 63);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[4] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Vinewhip() },
		[10] = new List<Move>() { new Moves.Wrap() },
		[13] = new List<Move>() { new Moves.Growth() },
		[16] = new List<Move>() { new Moves.Leaftornado() },
		[19] = new List<Move>() { new Moves.Leechseed() },
		[22] = new List<Move>() { new Moves.Megadrain() },
		[25] = new List<Move>() { new Moves.Slam() },
		[28] = new List<Move>() { new Moves.Leafblade() },
		[31] = new List<Move>() { new Moves.Coil() },
		[34] = new List<Move>() { new Moves.Gigadrain() },
		[37] = new List<Move>() { new Moves.Wringout() },
		[40] = new List<Move>() { new Moves.Gastroacid() },
		[43] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Torment(), new Moves.Toxic(), new Moves.Workup(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Captivate(), new Moves.Glare(), new Moves.Grassyterrain(), new Moves.Irontail(), new Moves.Magicalleaf(), new Moves.Meanlook(), new Moves.Mirrorcoat(), new Moves.Naturalgift(), new Moves.Pursuit(), new Moves.Sweetscent(), new Moves.Twister() };
	public override int Weight => 81;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
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