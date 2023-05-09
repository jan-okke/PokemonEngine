using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Durant : Pokemon
{
	public override string Name => "Durant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Hustle() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Truant() };
	public override Stats BaseStats => new Stats(58, 109, 112, 48, 48, 109);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Sandattack() },
		[4] = new List<Move>() { new Moves.Visegrip() },
		[8] = new List<Move>() { new Moves.Metalclaw() },
		[12] = new List<Move>() { new Moves.Beatup() },
		[16] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Agility() },
		[28] = new List<Move>() { new Moves.Dig() },
		[32] = new List<Move>() { new Moves.Xscissor() },
		[36] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Metalsound() },
		[44] = new List<Move>() { new Moves.Ironhead() },
		[48] = new List<Move>() { new Moves.Entrainment() },
		[52] = new List<Move>() { new Moves.Irondefense() },
		[56] = new List<Move>() { new Moves.Guillotine() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Beatup(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Firstimpression(), new Moves.Flail(), new Moves.Infestation(), new Moves.Metalburst(), new Moves.Strugglebug() };
	public override int Weight => 330;
	public override int ExpYield => 169;
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