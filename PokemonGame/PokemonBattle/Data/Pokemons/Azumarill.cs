using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Azumarill : Pokemon
{
	public override string Name => "Azumarill";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Hugepower() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
	public override Stats BaseStats => new Stats(100, 50, 80, 60, 80, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rollout(), new Moves.Defensecurl(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Tailwhip(), new Moves.Helpinghand() },
		[6] = new List<Move>() { new Moves.Bubblebeam() },
		[9] = new List<Move>() { new Moves.Charm() },
		[12] = new List<Move>() { new Moves.Slam() },
		[15] = new List<Move>() { new Moves.Bounce() },
		[21] = new List<Move>() { new Moves.Aquatail() },
		[25] = new List<Move>() { new Moves.Playrough() },
		[30] = new List<Move>() { new Moves.Aquaring() },
		[35] = new List<Move>() { new Moves.Raindance() },
		[40] = new List<Move>() { new Moves.Hydropump() },
		[45] = new List<Move>() { new Moves.Doubleedge() },
		[50] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
	public override int Weight => 285;
	public override int ExpYield => 210;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}