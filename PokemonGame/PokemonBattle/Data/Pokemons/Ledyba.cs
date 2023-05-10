using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ledyba : Pokemon
{
	public override string Name => "Ledyba";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(40, 20, 30, 40, 80, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Supersonic() },
		[8] = new List<Move>() { new Moves.Swift() },
		[12] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect(), new Moves.Safeguard() },
		[15] = new List<Move>() { new Moves.Machpunch() },
		[19] = new List<Move>() { new Moves.Roost() },
		[22] = new List<Move>() { new Moves.Strugglebug() },
		[26] = new List<Move>() { new Moves.Batonpass() },
		[29] = new List<Move>() { new Moves.Agility() },
		[33] = new List<Move>() { new Moves.Bugbuzz() },
		[36] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Uturn() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Counter(), new Moves.Encore(), new Moves.Knockoff(), new Moves.Psybeam(), new Moves.Screech(), new Moves.Tailwind() };
	public override int Weight => 108;
	public override int ExpYield => 53;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}