using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aegislash : Pokemon
{
	public override string Name => "Aegislash";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stancechange() };
	public override Stats BaseStats => new Stats(60, 50, 140, 50, 140, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Kingsshield() },
		[1] = new List<Move>() { new Moves.Kingsshield(), new Moves.Headsmash(), new Moves.Aerialace(), new Moves.Metalsound(), new Moves.Slash(), new Moves.Nightslash(), new Moves.Retaliate(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Powertrick(), new Moves.Swordsdance(), new Moves.Sacredsword(), new Moves.Tackle(), new Moves.Furycutter(), new Moves.Shadowsneak(), new Moves.Autotomize() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance() };
	public override int Weight => 530;
	public override int ExpYield => 250;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}