using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Skarmory : Pokemon
{
	public override string Name => "Skarmory";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(65, 80, 140, 40, 70, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[8] = new List<Move>() { new Moves.Furyattack() },
		[12] = new List<Move>() { new Moves.Metalclaw() },
		[16] = new List<Move>() { new Moves.Agility() },
		[20] = new List<Move>() { new Moves.Wingattack() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Steelwing() },
		[32] = new List<Move>() { new Moves.Autotomize() },
		[36] = new List<Move>() { new Moves.Drillpeck() },
		[40] = new List<Move>() { new Moves.Metalsound() },
		[44] = new List<Move>() { new Moves.Spikes() },
		[48] = new List<Move>() { new Moves.Irondefense() },
		[52] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bravebird(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aircutter(), new Moves.Assurance(), new Moves.Bravebird(), new Moves.Curse(), new Moves.Drillpeck(), new Moves.Feint(), new Moves.Guardswap(), new Moves.Nightslash(), new Moves.Skyattack(), new Moves.Whirlwind() };
	public override int Weight => 505;
	public override int ExpYield => 163;
	public override int CatchRate => 25;
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