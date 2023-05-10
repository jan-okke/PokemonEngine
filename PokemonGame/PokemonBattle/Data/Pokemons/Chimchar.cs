using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Chimchar : Pokemon
{
	public override string Name => "Chimchar";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Ironfist() };
	public override Stats BaseStats => new Stats(44, 58, 44, 58, 44, 61);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Ember() },
		[9] = new List<Move>() { new Moves.Taunt() },
		[12] = new List<Move>() { new Moves.Poweruppunch() },
		[15] = new List<Move>() { new Moves.Furyswipes() },
		[17] = new List<Move>() { new Moves.Flamewheel() },
		[23] = new List<Move>() { new Moves.Nastyplot() },
		[25] = new List<Move>() { new Moves.Torment() },
		[31] = new List<Move>() { new Moves.Facade() },
		[33] = new List<Move>() { new Moves.Firespin() },
		[39] = new List<Move>() { new Moves.Acrobatics() },
		[41] = new List<Move>() { new Moves.Slackoff() },
		[47] = new List<Move>() { new Moves.Flamethrower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Blazekick(), new Moves.Counter(), new Moves.Doublekick(), new Moves.Encore(), new Moves.Fakeout(), new Moves.Firepunch(), new Moves.Focusenergy(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Poweruppunch(), new Moves.Quickguard(), new Moves.Submission(), new Moves.Thunderpunch() };
	public override int Weight => 62;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}