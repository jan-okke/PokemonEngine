using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Darmanitan : Pokemon
{
	public override string Name => "Darmanitan";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Zenmode() };
	public override Stats BaseStats => new Stats(105, 140, 55, 30, 55, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Hammerarm() },
		[1] = new List<Move>() { new Moves.Hammerarm(), new Moves.Ember(), new Moves.Tackle(), new Moves.Taunt(), new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Incinerate() },
		[16] = new List<Move>() { new Moves.Workup() },
		[20] = new List<Move>() { new Moves.Firefang() },
		[24] = new List<Move>() { new Moves.Headbutt() },
		[28] = new List<Move>() { new Moves.Firepunch() },
		[32] = new List<Move>() { new Moves.Uproar() },
		[38] = new List<Move>() { new Moves.Bellydrum() },
		[44] = new List<Move>() { new Moves.Flareblitz() },
		[50] = new List<Move>() { new Moves.Thrash() },
		[56] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 929;
	public override int ExpYield => 168;
	public override int CatchRate => 60;
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