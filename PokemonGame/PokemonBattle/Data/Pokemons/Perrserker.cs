using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Perrserker : Pokemon
{
	public override string Name => "Perrserker";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor(), new Abilities.Toughclaws() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steelyspirit() };
	public override Stats BaseStats => new Stats(70, 110, 100, 50, 60, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Ironhead() },
		[1] = new List<Move>() { new Moves.Ironhead(), new Moves.Metalburst(), new Moves.Irondefense(), new Moves.Fakeout(), new Moves.Growl(), new Moves.Honeclaws(), new Moves.Scratch() },
		[12] = new List<Move>() { new Moves.Payday() },
		[16] = new List<Move>() { new Moves.Metalclaw() },
		[20] = new List<Move>() { new Moves.Taunt() },
		[24] = new List<Move>() { new Moves.Swagger() },
		[31] = new List<Move>() { new Moves.Furyswipes() },
		[36] = new List<Move>() { new Moves.Screech() },
		[42] = new List<Move>() { new Moves.Slash() },
		[48] = new List<Move>() { new Moves.Metalsound() },
		[54] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Covet(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Flail(), new Moves.Nightslash(), new Moves.Spite() };
	public override int Weight => 280;
	public override int ExpYield => 154;
	public override int CatchRate => 90;
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