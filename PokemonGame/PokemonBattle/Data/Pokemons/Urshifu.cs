using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Urshifu : Pokemon
{
	public override string Name => "Urshifu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Unseenfist() };
	public override Stats BaseStats => new Stats(100, 130, 100, 63, 60, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Wickedblow() },
		[1] = new List<Move>() { new Moves.Wickedblow(), new Moves.Suckerpunch(), new Moves.Rocksmash(), new Moves.Leer(), new Moves.Endure(), new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Aerialace() },
		[16] = new List<Move>() { new Moves.Scaryface() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Brickbreak() },
		[28] = new List<Move>() { new Moves.Detect() },
		[32] = new List<Move>() { new Moves.Bulkup() },
		[36] = new List<Move>() { new Moves.Ironhead() },
		[40] = new List<Move>() { new Moves.Dynamicpunch() },
		[44] = new List<Move>() { new Moves.Counter() },
		[48] = new List<Move>() { new Moves.Closecombat() },
		[52] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Beatup(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swift(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 1050;
	public override int ExpYield => 275;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}