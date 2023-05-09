using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Primeape : Pokemon
{
	public override string Name => "Primeape";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Vitalspirit(), new Abilities.Angerpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(65, 105, 60, 60, 70, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Finalgambit(), new Moves.Fling(), new Moves.Scratch(), new Moves.Lowkick(), new Moves.Leer(), new Moves.Focusenergy() },
		[5] = new List<Move>() { new Moves.Furyswipes() },
		[8] = new List<Move>() { new Moves.Mudslap() },
		[12] = new List<Move>() { new Moves.Seismictoss() },
		[15] = new List<Move>() { new Moves.Retaliate() },
		[19] = new List<Move>() { new Moves.Swagger() },
		[22] = new List<Move>() { new Moves.Crosschop() },
		[26] = new List<Move>() { new Moves.Assurance() },
		[30] = new List<Move>() { new Moves.Skullbash() },
		[35] = new List<Move>() { new Moves.Thrash() },
		[39] = new List<Move>() { new Moves.Closecombat() },
		[44] = new List<Move>() { new Moves.Screech() },
		[48] = new List<Move>() { new Moves.Stompingtantrum() },
		[53] = new List<Move>() { new Moves.Outrage() },
		[57] = new List<Move>() { new Moves.Finalgambit() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Spite(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 320;
	public override int ExpYield => 159;
	public override int CatchRate => 75;
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