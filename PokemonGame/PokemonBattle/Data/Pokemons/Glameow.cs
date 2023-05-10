using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Glameow : Pokemon
{
	public override string Name => "Glameow";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Owntempo() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Keeneye() };
	public override Stats BaseStats => new Stats(49, 55, 42, 42, 37, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Fakeout() },
		[5] = new List<Move>() { new Moves.Scratch() },
		[8] = new List<Move>() { new Moves.Growl() },
		[13] = new List<Move>() { new Moves.Hypnosis() },
		[17] = new List<Move>() { new Moves.Aerialace() },
		[20] = new List<Move>() { new Moves.Furyswipes() },
		[25] = new List<Move>() { new Moves.Charm() },
		[29] = new List<Move>() { new Moves.Taunt() },
		[32] = new List<Move>() { new Moves.Retaliate() },
		[37] = new List<Move>() { new Moves.Slash() },
		[41] = new List<Move>() { new Moves.Suckerpunch() },
		[44] = new List<Move>() { new Moves.Attract() },
		[48] = new List<Move>() { new Moves.Honeclaws() },
		[50] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Torment(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Bite(), new Moves.Faketears(), new Moves.Flail(), new Moves.Lastresort(), new Moves.Quickattack(), new Moves.Sandattack(), new Moves.Tailwhip() };
	public override int Weight => 39;
	public override int ExpYield => 62;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}