using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pinsir : Pokemon
{
	public override string Name => "Pinsir";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Moldbreaker() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
	public override Stats BaseStats => new Stats(65, 125, 100, 55, 70, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Visegrip(), new Moves.Harden() },
		[4] = new List<Move>() { new Moves.Focusenergy() },
		[8] = new List<Move>() { new Moves.Bind() },
		[12] = new List<Move>() { new Moves.Seismictoss() },
		[16] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Stormthrow() },
		[24] = new List<Move>() { new Moves.Doublehit() },
		[28] = new List<Move>() { new Moves.Vitalthrow() },
		[32] = new List<Move>() { new Moves.Xscissor() },
		[36] = new List<Move>() { new Moves.Strength() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[44] = new List<Move>() { new Moves.Submission() },
		[48] = new List<Move>() { new Moves.Guillotine() },
		[52] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Closecombat(), new Moves.Feint(), new Moves.Flail(), new Moves.Furyattack(), new Moves.Quickattack(), new Moves.Superpower(), new Moves.Thrash() };
	public override int Weight => 550;
	public override int ExpYield => 175;
	public override int CatchRate => 45;
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