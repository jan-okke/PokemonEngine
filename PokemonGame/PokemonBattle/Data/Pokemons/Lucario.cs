using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lucario : Pokemon
{
	public override string Name => "Lucario";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Steadfast(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Justified() };
	public override Stats BaseStats => new Stats(70, 110, 70, 115, 70, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Aurasphere() },
		[1] = new List<Move>() { new Moves.Aurasphere(), new Moves.Lifedew(), new Moves.Workup(), new Moves.Rocksmash(), new Moves.Nastyplot(), new Moves.Screech(), new Moves.Forcepalm(), new Moves.Helpinghand(), new Moves.Copycat(), new Moves.Finalgambit(), new Moves.Reversal(), new Moves.Quickattack(), new Moves.Detect(), new Moves.Feint(), new Moves.Metalclaw() },
		[12] = new List<Move>() { new Moves.Counter() },
		[16] = new List<Move>() { new Moves.Laserfocus() },
		[20] = new List<Move>() { new Moves.Poweruppunch() },
		[24] = new List<Move>() { new Moves.Calmmind() },
		[28] = new List<Move>() { new Moves.Metalsound() },
		[32] = new List<Move>() { new Moves.Quickguard() },
		[36] = new List<Move>() { new Moves.Bonerush() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[44] = new List<Move>() { new Moves.Healpulse() },
		[48] = new List<Move>() { new Moves.Meteormash() },
		[52] = new List<Move>() { new Moves.Dragonpulse() },
		[56] = new List<Move>() { new Moves.Extremespeed() },
		[60] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Blazekick(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Thunderpunch(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 540;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
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