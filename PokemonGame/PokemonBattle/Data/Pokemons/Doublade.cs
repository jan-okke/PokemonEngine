using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Doublade : Pokemon
{
	public override string Name => "Doublade";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Noguard() };
	public override Stats BaseStats => new Stats(59, 110, 150, 45, 49, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Furycutter(), new Moves.Shadowsneak(), new Moves.Autotomize() },
		[12] = new List<Move>() { new Moves.Aerialace() },
		[16] = new List<Move>() { new Moves.Metalsound() },
		[20] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Nightslash() },
		[28] = new List<Move>() { new Moves.Retaliate() },
		[32] = new List<Move>() { new Moves.Irondefense() },
		[38] = new List<Move>() { new Moves.Ironhead() },
		[44] = new List<Move>() { new Moves.Powertrick() },
		[50] = new List<Move>() { new Moves.Swordsdance() },
		[56] = new List<Move>() { new Moves.Sacredsword() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swordsdance() };
	public override int Weight => 45;
	public override int ExpYield => 157;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}