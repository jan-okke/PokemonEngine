using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Buzzwole : Pokemon
{
	public override string Name => "Buzzwole";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(107, 139, 139, 53, 53, 79);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poweruppunch(), new Moves.Harden() },
		[5] = new List<Move>() { new Moves.Taunt() },
		[10] = new List<Move>() { new Moves.Fellstinger() },
		[15] = new List<Move>() { new Moves.Vitalthrow() },
		[20] = new List<Move>() { new Moves.Bulkup() },
		[25] = new List<Move>() { new Moves.Endure() },
		[30] = new List<Move>() { new Moves.Reversal() },
		[35] = new List<Move>() { new Moves.Megapunch() },
		[40] = new List<Move>() { new Moves.Lunge() },
		[45] = new List<Move>() { new Moves.Focusenergy() },
		[50] = new List<Move>() { new Moves.Dynamicpunch() },
		[55] = new List<Move>() { new Moves.Counter() },
		[60] = new List<Move>() { new Moves.Hammerarm() },
		[65] = new List<Move>() { new Moves.Superpower() },
		[70] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Darkestlariat(), new Moves.Drainpunch(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Leechlife(), new Moves.Lowsweep(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override int Weight => 3336;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}