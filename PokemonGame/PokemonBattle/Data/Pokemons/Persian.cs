using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Persian : Pokemon
{
	public override string Name => "Persian";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(65, 70, 60, 65, 65, 115);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Powergem() },
		[1] = new List<Move>() { new Moves.Powergem(), new Moves.Switcheroo(), new Moves.Fakeout(), new Moves.Growl(), new Moves.Feint(), new Moves.Scratch() },
		[12] = new List<Move>() { new Moves.Payday() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Taunt() },
		[24] = new List<Move>() { new Moves.Assurance() },
		[31] = new List<Move>() { new Moves.Furyswipes() },
		[36] = new List<Move>() { new Moves.Screech() },
		[42] = new List<Move>() { new Moves.Slash() },
		[48] = new List<Move>() { new Moves.Nastyplot() },
		[54] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Torment(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 320;
	public override int ExpYield => 154;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}