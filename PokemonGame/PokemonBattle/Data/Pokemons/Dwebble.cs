using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dwebble : Pokemon
{
	public override string Name => "Dwebble";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(50, 65, 85, 35, 35, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Sandattack() },
		[4] = new List<Move>() { new Moves.Withdraw() },
		[8] = new List<Move>() { new Moves.Smackdown() },
		[12] = new List<Move>() { new Moves.Bugbite() },
		[16] = new List<Move>() { new Moves.Flail() },
		[20] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Rockslide() },
		[28] = new List<Move>() { new Moves.Stealthrock() },
		[32] = new List<Move>() { new Moves.Rockblast() },
		[36] = new List<Move>() { new Moves.Xscissor() },
		[40] = new List<Move>() { new Moves.Rockpolish() },
		[44] = new List<Move>() { new Moves.Shellsmash() },
		[48] = new List<Move>() { new Moves.Rockwrecker() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Counter(), new Moves.Curse(), new Moves.Knockoff(), new Moves.Nightslash(), new Moves.Wideguard() };
	public override int Weight => 145;
	public override int ExpYield => 65;
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