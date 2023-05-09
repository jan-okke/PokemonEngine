using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Arbok : Pokemon
{
	public override string Name => "Arbok";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(60, 95, 69, 65, 79, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Crunch() },
		[1] = new List<Move>() { new Moves.Crunch(), new Moves.Icefang(), new Moves.Thunderfang(), new Moves.Firefang(), new Moves.Wrap(), new Moves.Leer(), new Moves.Poisonsting(), new Moves.Bite() },
		[4] = new List<Move>() { new Moves.Poisonsting() },
		[9] = new List<Move>() { new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Glare() },
		[17] = new List<Move>() { new Moves.Screech() },
		[20] = new List<Move>() { new Moves.Acid() },
		[27] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[32] = new List<Move>() { new Moves.Acidspray() },
		[39] = new List<Move>() { new Moves.Sludgebomb() },
		[44] = new List<Move>() { new Moves.Gastroacid() },
		[48] = new List<Move>() { new Moves.Belch() },
		[51] = new List<Move>() { new Moves.Haze() },
		[56] = new List<Move>() { new Moves.Coil() },
		[63] = new List<Move>() { new Moves.Gunkshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragontail(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Irontail(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Venoshock() };
	public override int Weight => 650;
	public override int ExpYield => 157;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}