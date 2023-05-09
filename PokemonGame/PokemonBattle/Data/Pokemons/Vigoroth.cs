using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vigoroth : Pokemon
{
	public override string Name => "Vigoroth";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Vitalspirit() };
	public override Stats BaseStats => new Stats(80, 80, 80, 55, 55, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Reversal(), new Moves.Scratch(), new Moves.Focusenergy(), new Moves.Encore(), new Moves.Uproar() },
		[6] = new List<Move>() { new Moves.Encore() },
		[9] = new List<Move>() { new Moves.Uproar() },
		[14] = new List<Move>() { new Moves.Furyswipes() },
		[17] = new List<Move>() { new Moves.Endure() },
		[23] = new List<Move>() { new Moves.Slash() },
		[27] = new List<Move>() { new Moves.Headbutt() },
		[33] = new List<Move>() { new Moves.Counter() },
		[37] = new List<Move>() { new Moves.Focuspunch() },
		[43] = new List<Move>() { new Moves.Reversal() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 465;
	public override int ExpYield => 154;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}