using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ledian : Pokemon
{
	public override string Name => "Ledian";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Ironfist() };
	public override Stats BaseStats => new Stats(55, 35, 50, 55, 110, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Supersonic(), new Moves.Swift() },
		[5] = new List<Move>() { new Moves.Supersonic() },
		[8] = new List<Move>() { new Moves.Swift() },
		[12] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect(), new Moves.Safeguard() },
		[15] = new List<Move>() { new Moves.Machpunch() },
		[20] = new List<Move>() { new Moves.Roost() },
		[24] = new List<Move>() { new Moves.Strugglebug() },
		[29] = new List<Move>() { new Moves.Batonpass() },
		[33] = new List<Move>() { new Moves.Agility() },
		[38] = new List<Move>() { new Moves.Bugbuzz() },
		[42] = new List<Move>() { new Moves.Airslash() },
		[47] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Uturn() };
	public override int Weight => 356;
	public override int ExpYield => 137;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}