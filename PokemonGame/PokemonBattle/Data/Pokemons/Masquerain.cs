using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Masquerain : Pokemon
{
	public override string Name => "Masquerain";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(70, 60, 62, 100, 82, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quiverdance(), new Moves.Whirlwind(), new Moves.Bugbuzz(), new Moves.Quickattack(), new Moves.Sweetscent() },
		[6] = new List<Move>() { new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Sweetscent() },
		[14] = new List<Move>() { new Moves.Soak() },
		[17] = new List<Move>() { new Moves.Gust() },
		[22] = new List<Move>() { new Moves.Scaryface(), new Moves.Aircutter() },
		[26] = new List<Move>() { new Moves.Stunspore() },
		[32] = new List<Move>() { new Moves.Supersonic() },
		[38] = new List<Move>() { new Moves.Airslash() },
		[42] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Whirlwind() },
		[52] = new List<Move>() { new Moves.Quiverdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Infestation(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uturn(), new Moves.Waterpulse() };
	public override int Weight => 36;
	public override int ExpYield => 159;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}