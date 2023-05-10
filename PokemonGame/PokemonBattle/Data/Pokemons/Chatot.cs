using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Chatot : Pokemon
{
	public override string Name => "Chatot";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Tangledfeet() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bigpecks() };
	public override Stats BaseStats => new Stats(76, 65, 45, 92, 42, 91);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Hypervoice(), new Moves.Chatter(), new Moves.Confide(), new Moves.Taunt() },
		[5] = new List<Move>() { new Moves.Peck() },
		[9] = new List<Move>() { new Moves.Growl() },
		[13] = new List<Move>() { new Moves.Sing() },
		[17] = new List<Move>() { new Moves.Furyattack() },
		[21] = new List<Move>() { new Moves.Chatter() },
		[25] = new List<Move>() { new Moves.Taunt() },
		[29] = new List<Move>() { new Moves.Round() },
		[33] = new List<Move>() { new Moves.Mimic() },
		[37] = new List<Move>() { new Moves.Echoedvoice() },
		[41] = new List<Move>() { new Moves.Roost() },
		[45] = new List<Move>() { new Moves.Uproar() },
		[49] = new List<Move>() { new Moves.Partingshot() },
		[50] = new List<Move>() { new Moves.Featherdance() },
		[57] = new List<Move>() { new Moves.Hypervoice() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Nastyplot(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Aircutter(), new Moves.Boomburst(), new Moves.Encore(), new Moves.Nightshade(), new Moves.Supersonic() };
	public override int Weight => 19;
	public override int ExpYield => 144;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}