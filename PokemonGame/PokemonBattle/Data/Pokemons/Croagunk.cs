using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Croagunk : Pokemon
{
	public override string Name => "Croagunk";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Anticipation(), new Abilities.Dryskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Poisontouch() };
	public override Stats BaseStats => new Stats(48, 61, 40, 61, 40, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Mudslap() },
		[4] = new List<Move>() { new Moves.Astonish() },
		[8] = new List<Move>() { new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Flatter() },
		[16] = new List<Move>() { new Moves.Revenge() },
		[20] = new List<Move>() { new Moves.Venoshock() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Swagger() },
		[32] = new List<Move>() { new Moves.Poisonjab() },
		[36] = new List<Move>() { new Moves.Toxic() },
		[40] = new List<Move>() { new Moves.Nastyplot() },
		[44] = new List<Move>() { new Moves.Sludgebomb() },
		[48] = new List<Move>() { new Moves.Belch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Coaching(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Toxic(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Workup(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acupressure(), new Moves.Bulletpunch(), new Moves.Counter(), new Moves.Crosschop(), new Moves.Dynamicpunch(), new Moves.Fakeout(), new Moves.Feint(), new Moves.Headbutt(), new Moves.Quickguard(), new Moves.Vacuumwave() };
	public override int Weight => 230;
	public override int ExpYield => 60;
	public override int CatchRate => 140;
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