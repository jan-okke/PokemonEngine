using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pangoro : Pokemon
{
	public override string Name => "Pangoro";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironfist(), new Abilities.Moldbreaker() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
	public override Stats BaseStats => new Stats(95, 124, 78, 69, 71, 58);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Nightslash() },
		[1] = new List<Move>() { new Moves.Nightslash(), new Moves.Bulletpunch(), new Moves.Tackle(), new Moves.Leer(), new Moves.Armthrust(), new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Circlethrow() },
		[16] = new List<Move>() { new Moves.Lowsweep() },
		[20] = new List<Move>() { new Moves.Workup() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Vitalthrow() },
		[35] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Bodyslam() },
		[46] = new List<Move>() { new Moves.Partingshot() },
		[52] = new List<Move>() { new Moves.Entrainment() },
		[58] = new List<Move>() { new Moves.Hammerarm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dragonclaw(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 1360;
	public override int ExpYield => 173;
	public override int CatchRate => 65;
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