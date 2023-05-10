using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Seviper : Pokemon
{
	public override string Name => "Seviper";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(73, 100, 60, 100, 60, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Swagger() },
		[4] = new List<Move>() { new Moves.Bite() },
		[6] = new List<Move>() { new Moves.Lick() },
		[9] = new List<Move>() { new Moves.Poisontail() },
		[11] = new List<Move>() { new Moves.Feint() },
		[14] = new List<Move>() { new Moves.Screech() },
		[16] = new List<Move>() { new Moves.Venoshock() },
		[19] = new List<Move>() { new Moves.Glare() },
		[21] = new List<Move>() { new Moves.Poisonfang() },
		[24] = new List<Move>() { new Moves.Venomdrench() },
		[26] = new List<Move>() { new Moves.Nightslash() },
		[29] = new List<Move>() { new Moves.Gastroacid() },
		[31] = new List<Move>() { new Moves.Poisonjab() },
		[34] = new List<Move>() { new Moves.Haze() },
		[36] = new List<Move>() { new Moves.Swordsdance() },
		[39] = new List<Move>() { new Moves.Crunch() },
		[41] = new List<Move>() { new Moves.Belch() },
		[44] = new List<Move>() { new Moves.Coil() },
		[46] = new List<Move>() { new Moves.Sludgebomb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragontail(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snatch(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Bodyslam(), new Moves.Finalgambit(), new Moves.Nightslash(), new Moves.Scaryface(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Switcheroo() };
	public override int Weight => 525;
	public override int ExpYield => 160;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}