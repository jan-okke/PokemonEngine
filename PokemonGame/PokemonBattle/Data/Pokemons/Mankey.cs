using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mankey : Pokemon
{
	public override string Name => "Mankey";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Vitalspirit(), new Abilities.Angerpoint() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(40, 80, 35, 35, 45, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Covet(), new Moves.Scratch(), new Moves.Lowkick(), new Moves.Leer(), new Moves.Focusenergy() },
		[5] = new List<Move>() { new Moves.Furyswipes() },
		[8] = new List<Move>() { new Moves.Mudslap() },
		[12] = new List<Move>() { new Moves.Seismictoss() },
		[15] = new List<Move>() { new Moves.Retaliate() },
		[19] = new List<Move>() { new Moves.Swagger() },
		[22] = new List<Move>() { new Moves.Crosschop() },
		[26] = new List<Move>() { new Moves.Assurance() },
		[29] = new List<Move>() { new Moves.Skullbash() },
		[33] = new List<Move>() { new Moves.Thrash() },
		[36] = new List<Move>() { new Moves.Closecombat() },
		[40] = new List<Move>() { new Moves.Screech() },
		[43] = new List<Move>() { new Moves.Stompingtantrum() },
		[47] = new List<Move>() { new Moves.Outrage() },
		[50] = new List<Move>() { new Moves.Finalgambit() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Spite(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Beatup(), new Moves.Closecombat(), new Moves.Counter(), new Moves.Encore(), new Moves.Nightslash(), new Moves.Revenge(), new Moves.Reversal() };
	public override int Weight => 280;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}