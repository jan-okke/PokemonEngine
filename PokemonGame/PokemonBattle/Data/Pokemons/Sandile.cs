using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sandile : Pokemon
{
	public override string Name => "Sandile";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Moxie() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Angerpoint() };
	public override Stats BaseStats => new Stats(50, 72, 35, 35, 35, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powertrip(), new Moves.Leer() },
		[3] = new List<Move>() { new Moves.Sandattack() },
		[6] = new List<Move>() { new Moves.Honeclaws() },
		[9] = new List<Move>() { new Moves.Sandtomb() },
		[12] = new List<Move>() { new Moves.Scaryface() },
		[15] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Torment() },
		[21] = new List<Move>() { new Moves.Dig() },
		[24] = new List<Move>() { new Moves.Swagger() },
		[27] = new List<Move>() { new Moves.Crunch() },
		[30] = new List<Move>() { new Moves.Sandstorm() },
		[33] = new List<Move>() { new Moves.Foulplay() },
		[36] = new List<Move>() { new Moves.Earthquake() },
		[39] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Counter(), new Moves.Doubleedge(), new Moves.Spite() };
	public override int Weight => 152;
	public override int ExpYield => 58;
	public override int CatchRate => 180;
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