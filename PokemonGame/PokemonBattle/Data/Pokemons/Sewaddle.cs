using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sewaddle : Pokemon
{
	public override string Name => "Sewaddle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(45, 53, 70, 40, 60, 42);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Stringshot() },
		[8] = new List<Move>() { new Moves.Bugbite() },
		[15] = new List<Move>() { new Moves.Razorleaf() },
		[22] = new List<Move>() { new Moves.Strugglebug() },
		[29] = new List<Move>() { new Moves.Endure() },
		[31] = new List<Move>() { new Moves.Stickyweb() },
		[36] = new List<Move>() { new Moves.Bugbuzz() },
		[43] = new List<Move>() { new Moves.Flail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbite(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Batonpass(), new Moves.Camouflage(), new Moves.Grassyterrain(), new Moves.Mefirst(), new Moves.Mindreader(), new Moves.Razorwind(), new Moves.Screech(), new Moves.Silverwind() };
	public override int Weight => 25;
	public override int ExpYield => 62;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}