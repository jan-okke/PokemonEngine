using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Horsea : Pokemon
{
	public override string Name => "Horsea";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
	public override Stats BaseStats => new Stats(30, 40, 70, 70, 25, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Smokescreen() },
		[10] = new List<Move>() { new Moves.Twister() },
		[15] = new List<Move>() { new Moves.Focusenergy() },
		[20] = new List<Move>() { new Moves.Dragonbreath() },
		[25] = new List<Move>() { new Moves.Bubblebeam() },
		[30] = new List<Move>() { new Moves.Agility() },
		[35] = new List<Move>() { new Moves.Laserfocus() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[45] = new List<Move>() { new Moves.Hydropump() },
		[50] = new List<Move>() { new Moves.Dragondance() },
		[55] = new List<Move>() { new Moves.Raindance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Focusenergy(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aurorabeam(), new Moves.Clearsmog(), new Moves.Disable(), new Moves.Dragonbreath(), new Moves.Flail(), new Moves.Muddywater(), new Moves.Octazooka(), new Moves.Outrage(), new Moves.Splash() };
	public override int Weight => 80;
	public override int ExpYield => 59;
	public override int CatchRate => 225;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}