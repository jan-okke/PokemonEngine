using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Riolu : Pokemon
{
	public override string Name => "Riolu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Steadfast(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
	public override Stats BaseStats => new Stats(40, 70, 40, 35, 40, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Endure() },
		[4] = new List<Move>() { new Moves.Feint() },
		[8] = new List<Move>() { new Moves.Metalclaw() },
		[12] = new List<Move>() { new Moves.Counter() },
		[16] = new List<Move>() { new Moves.Workup() },
		[20] = new List<Move>() { new Moves.Rocksmash() },
		[24] = new List<Move>() { new Moves.Nastyplot() },
		[28] = new List<Move>() { new Moves.Screech() },
		[32] = new List<Move>() { new Moves.Quickguard() },
		[36] = new List<Move>() { new Moves.Forcepalm() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[44] = new List<Move>() { new Moves.Helpinghand() },
		[48] = new List<Move>() { new Moves.Copycat() },
		[52] = new List<Move>() { new Moves.Finalgambit() },
		[56] = new List<Move>() { new Moves.Reversal() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Blazekick(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Bite(), new Moves.Blazekick(), new Moves.Bulletpunch(), new Moves.Circlethrow(), new Moves.Crosschop(), new Moves.Crunch(), new Moves.Detect(), new Moves.Followme(), new Moves.Highjumpkick(), new Moves.Howl(), new Moves.Irondefense(), new Moves.Lowkick(), new Moves.Meteormash(), new Moves.Mindreader(), new Moves.Vacuumwave() };
	public override int Weight => 202;
	public override int ExpYield => 57;
	public override int CatchRate => 75;
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