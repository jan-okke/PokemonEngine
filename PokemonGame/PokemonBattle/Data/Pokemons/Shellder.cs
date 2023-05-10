using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shellder : Pokemon
{
	public override string Name => "Shellder";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shellarmor(), new Abilities.Skilllink() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(30, 65, 100, 45, 25, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Watergun() },
		[4] = new List<Move>() { new Moves.Withdraw() },
		[8] = new List<Move>() { new Moves.Iceshard() },
		[12] = new List<Move>() { new Moves.Leer() },
		[16] = new List<Move>() { new Moves.Whirlpool() },
		[20] = new List<Move>() { new Moves.Supersonic() },
		[24] = new List<Move>() { new Moves.Aurorabeam() },
		[28] = new List<Move>() { new Moves.Protect() },
		[32] = new List<Move>() { new Moves.Razorshell() },
		[36] = new List<Move>() { new Moves.Irondefense() },
		[40] = new List<Move>() { new Moves.Icebeam() },
		[44] = new List<Move>() { new Moves.Shellsmash() },
		[48] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Triattack(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Bubblebeam(), new Moves.Iciclespear(), new Moves.Lifedew(), new Moves.Mudshot(), new Moves.Rapidspin(), new Moves.Rockblast(), new Moves.Screech(), new Moves.Takedown() };
	public override int Weight => 40;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}