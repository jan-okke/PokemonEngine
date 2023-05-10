using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Falinks : Pokemon
{
	public override string Name => "Falinks";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(65, 100, 100, 70, 60, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Protect() },
		[5] = new List<Move>() { new Moves.Rocksmash() },
		[10] = new List<Move>() { new Moves.Focusenergy() },
		[15] = new List<Move>() { new Moves.Headbutt() },
		[20] = new List<Move>() { new Moves.Bulkup() },
		[25] = new List<Move>() { new Moves.Endure() },
		[30] = new List<Move>() { new Moves.Reversal() },
		[35] = new List<Move>() { new Moves.Firstimpression() },
		[40] = new List<Move>() { new Moves.Noretreat() },
		[45] = new List<Move>() { new Moves.Irondefense() },
		[50] = new List<Move>() { new Moves.Closecombat() },
		[55] = new List<Move>() { new Moves.Megahorn() },
		[60] = new List<Move>() { new Moves.Counter() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megahorn(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Zenheadbutt() };
	public override int Weight => 620;
	public override int ExpYield => 165;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}