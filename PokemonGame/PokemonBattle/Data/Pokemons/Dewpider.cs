using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dewpider : Pokemon
{
	public override string Name => "Dewpider";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterbubble() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(38, 40, 52, 40, 72, 27);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Infestation() },
		[4] = new List<Move>() { new Moves.Bugbite() },
		[8] = new List<Move>() { new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Bubblebeam() },
		[16] = new List<Move>() { new Moves.Aquaring() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Crunch() },
		[28] = new List<Move>() { new Moves.Soak() },
		[32] = new List<Move>() { new Moves.Entrainment() },
		[36] = new List<Move>() { new Moves.Lunge() },
		[40] = new List<Move>() { new Moves.Liquidation() },
		[44] = new List<Move>() { new Moves.Leechlife() },
		[48] = new List<Move>() { new Moves.Mirrorcoat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bugbuzz(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Liquidation(), new Moves.Magicroom(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Wonderroom(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Powersplit(), new Moves.Spitup(), new Moves.Stickyweb(), new Moves.Stockpile() };
	public override int Weight => 40;
	public override int ExpYield => 54;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}