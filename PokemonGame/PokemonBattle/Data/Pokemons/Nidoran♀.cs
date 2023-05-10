using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Nidoranfe : Pokemon
{
	public override string Name => "Nidoran♀";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Rivalry() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(55, 47, 52, 40, 40, 41);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Poisonsting() },
		[5] = new List<Move>() { new Moves.Scratch() },
		[10] = new List<Move>() { new Moves.Tailwhip() },
		[15] = new List<Move>() { new Moves.Furyswipes() },
		[20] = new List<Move>() { new Moves.Toxicspikes() },
		[25] = new List<Move>() { new Moves.Doublekick() },
		[30] = new List<Move>() { new Moves.Bite() },
		[35] = new List<Move>() { new Moves.Helpinghand() },
		[40] = new List<Move>() { new Moves.Toxic() },
		[45] = new List<Move>() { new Moves.Flatter() },
		[50] = new List<Move>() { new Moves.Crunch() },
		[55] = new List<Move>() { new Moves.Earthpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Beatup(), new Moves.Charm(), new Moves.Counter(), new Moves.Disable(), new Moves.Focusenergy(), new Moves.Poisonfang(), new Moves.Poisontail(), new Moves.Skullbash(), new Moves.Supersonic(), new Moves.Takedown(), new Moves.Venomdrench() };
	public override int Weight => 70;
	public override int ExpYield => 55;
	public override int CatchRate => 235;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}