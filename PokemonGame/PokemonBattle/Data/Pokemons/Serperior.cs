using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Serperior : Pokemon
{
	public override string Name => "Serperior";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
	public override Stats BaseStats => new Stats(75, 75, 95, 75, 95, 113);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer(), new Moves.Vinewhip(), new Moves.Wrap() },
		[4] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Vinewhip() },
		[10] = new List<Move>() { new Moves.Wrap() },
		[13] = new List<Move>() { new Moves.Growth() },
		[16] = new List<Move>() { new Moves.Leaftornado() },
		[20] = new List<Move>() { new Moves.Leechseed() },
		[24] = new List<Move>() { new Moves.Megadrain() },
		[28] = new List<Move>() { new Moves.Slam() },
		[32] = new List<Move>() { new Moves.Leafblade() },
		[38] = new List<Move>() { new Moves.Coil() },
		[44] = new List<Move>() { new Moves.Gigadrain() },
		[50] = new List<Move>() { new Moves.Wringout() },
		[56] = new List<Move>() { new Moves.Gastroacid() },
		[62] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Dragontail(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frenzyplant(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Outrage(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Torment(), new Moves.Toxic(), new Moves.Workup(), new Moves.Worryseed() };
	public override int Weight => 630;
	public override int ExpYield => 264;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}