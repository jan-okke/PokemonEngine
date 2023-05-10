using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Passimian : Pokemon
{
	public override string Name => "Passimian";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Receiver() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(100, 120, 90, 40, 60, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Rocksmash() },
		[10] = new List<Move>() { new Moves.Focusenergy() },
		[15] = new List<Move>() { new Moves.Beatup() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[25] = new List<Move>() { new Moves.Takedown() },
		[30] = new List<Move>() { new Moves.Fling() },
		[35] = new List<Move>() { new Moves.Bulkup() },
		[40] = new List<Move>() { new Moves.Thrash() },
		[45] = new List<Move>() { new Moves.Doubleedge() },
		[50] = new List<Move>() { new Moves.Closecombat() },
		[55] = new List<Move>() { new Moves.Reversal() },
		[60] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Feint(), new Moves.Knockoff(), new Moves.Quickattack(), new Moves.Quickguard(), new Moves.Seismictoss(), new Moves.Vitalthrow() };
	public override int Weight => 828;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}