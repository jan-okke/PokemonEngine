using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Azurill : Pokemon
{
	public override string Name => "Azurill";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Hugepower() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
	public override Stats BaseStats => new Stats(50, 20, 40, 20, 40, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash(), new Moves.Watergun(), new Moves.Tailwhip() },
		[3] = new List<Move>() { new Moves.Helpinghand() },
		[6] = new List<Move>() { new Moves.Bubblebeam() },
		[9] = new List<Move>() { new Moves.Charm() },
		[12] = new List<Move>() { new Moves.Slam() },
		[15] = new List<Move>() { new Moves.Bounce() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brutalswing(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Bellydrum(), new Moves.Bodyslam(), new Moves.Copycat(), new Moves.Encore(), new Moves.Faketears(), new Moves.Muddywater(), new Moves.Perishsong(), new Moves.Present(), new Moves.Sing(), new Moves.Slam(), new Moves.Soak(), new Moves.Supersonic(), new Moves.Tickle() };
	public override int Weight => 20;
	public override int ExpYield => 38;
	public override int CatchRate => 150;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}