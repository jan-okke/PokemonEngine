using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kingdra : Pokemon
{
	public override string Name => "Kingdra";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
	public override Stats BaseStats => new Stats(75, 95, 95, 95, 95, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Whirlpool(), new Moves.Yawn(), new Moves.Watergun(), new Moves.Leer(), new Moves.Smokescreen(), new Moves.Twister() },
		[15] = new List<Move>() { new Moves.Focusenergy() },
		[20] = new List<Move>() { new Moves.Dragonbreath() },
		[25] = new List<Move>() { new Moves.Bubblebeam() },
		[30] = new List<Move>() { new Moves.Agility() },
		[37] = new List<Move>() { new Moves.Laserfocus() },
		[44] = new List<Move>() { new Moves.Dragonpulse() },
		[51] = new List<Move>() { new Moves.Hydropump() },
		[58] = new List<Move>() { new Moves.Dragondance() },
		[65] = new List<Move>() { new Moves.Raindance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Breakingswipe(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 1520;
	public override int ExpYield => 270;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}