using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Charmander : Pokemon
{
	public override string Name => "Charmander";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Solarpower() };
	public override Stats BaseStats => new Stats(39, 52, 43, 60, 50, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Smokescreen() },
		[12] = new List<Move>() { new Moves.Dragonbreath() },
		[17] = new List<Move>() { new Moves.Firefang() },
		[20] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Flamethrower() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[32] = new List<Move>() { new Moves.Firespin() },
		[36] = new List<Move>() { new Moves.Inferno() },
		[40] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thunderpunch(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aircutter(), new Moves.Ancientpower(), new Moves.Beatup(), new Moves.Bellydrum(), new Moves.Bite(), new Moves.Counter(), new Moves.Crunch(), new Moves.Dragondance(), new Moves.Dragonrush(), new Moves.Dragontail(), new Moves.Flareblitz(), new Moves.Metalclaw(), new Moves.Outrage(), new Moves.Wingattack() };
	public override int Weight => 85;
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