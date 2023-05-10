using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Leavanny : Pokemon
{
	public override string Name => "Leavanny";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(75, 103, 80, 70, 80, 92);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slash() },
		[1] = new List<Move>() { new Moves.Slash(), new Moves.Falseswipe(), new Moves.Tackle(), new Moves.Stringshot(), new Moves.Bugbite(), new Moves.Razorleaf() },
		[8] = new List<Move>() { new Moves.Bugbite() },
		[15] = new List<Move>() { new Moves.Razorleaf() },
		[22] = new List<Move>() { new Moves.Strugglebug() },
		[29] = new List<Move>() { new Moves.Fellstinger() },
		[32] = new List<Move>() { new Moves.Helpinghand() },
		[36] = new List<Move>() { new Moves.Leafblade() },
		[39] = new List<Move>() { new Moves.Xscissor() },
		[43] = new List<Move>() { new Moves.Entrainment() },
		[46] = new List<Move>() { new Moves.Swordsdance() },
		[50] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Throatchop(), new Moves.Toxic(), new Moves.Worryseed(), new Moves.Xscissor() };
	public override int Weight => 205;
	public override int ExpYield => 250;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}