using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Nidoranma : Pokemon
{
	public override string Name => "Nidoran♂";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Rivalry() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(46, 57, 40, 40, 40, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leer(), new Moves.Poisonsting() },
		[5] = new List<Move>() { new Moves.Peck() },
		[10] = new List<Move>() { new Moves.Focusenergy() },
		[15] = new List<Move>() { new Moves.Furyattack() },
		[20] = new List<Move>() { new Moves.Toxicspikes() },
		[25] = new List<Move>() { new Moves.Doublekick() },
		[30] = new List<Move>() { new Moves.Hornattack() },
		[35] = new List<Move>() { new Moves.Helpinghand() },
		[40] = new List<Move>() { new Moves.Toxic() },
		[45] = new List<Move>() { new Moves.Flatter() },
		[50] = new List<Move>() { new Moves.Poisonjab() },
		[55] = new List<Move>() { new Moves.Earthpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Beatup(), new Moves.Confusion(), new Moves.Counter(), new Moves.Disable(), new Moves.Headsmash(), new Moves.Horndrill(), new Moves.Poisontail(), new Moves.Suckerpunch(), new Moves.Supersonic(), new Moves.Takedown(), new Moves.Thrash(), new Moves.Venomdrench() };
	public override int Weight => 90;
	public override int ExpYield => 55;
	public override int CatchRate => 235;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}