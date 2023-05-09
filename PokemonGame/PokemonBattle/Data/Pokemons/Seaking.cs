using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Seaking : Pokemon
{
	public override string Name => "Seaking";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Waterveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightningrod() };
	public override Stats BaseStats => new Stats(80, 92, 65, 65, 80, 68);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Tailwhip(), new Moves.Supersonic(), new Moves.Waterpulse() },
		[15] = new List<Move>() { new Moves.Hornattack() },
		[20] = new List<Move>() { new Moves.Agility() },
		[25] = new List<Move>() { new Moves.Aquaring() },
		[30] = new List<Move>() { new Moves.Flail() },
		[37] = new List<Move>() { new Moves.Waterfall() },
		[44] = new List<Move>() { new Moves.Soak() },
		[51] = new List<Move>() { new Moves.Megahorn() },
		[58] = new List<Move>() { new Moves.Horndrill() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Megahorn(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 390;
	public override int ExpYield => 158;
	public override int CatchRate => 60;
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