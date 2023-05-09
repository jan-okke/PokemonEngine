using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sliggoo : Pokemon
{
	public override string Name => "Sliggoo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sapsipper(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gooey() };
	public override Stats BaseStats => new Stats(68, 75, 53, 83, 113, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Acidspray() },
		[1] = new List<Move>() { new Moves.Acidspray(), new Moves.Absorb(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Dragonbreath() },
		[15] = new List<Move>() { new Moves.Protect() },
		[20] = new List<Move>() { new Moves.Flail() },
		[25] = new List<Move>() { new Moves.Waterpulse() },
		[30] = new List<Move>() { new Moves.Raindance() },
		[35] = new List<Move>() { new Moves.Dragonpulse() },
		[43] = new List<Move>() { new Moves.Curse() },
		[49] = new List<Move>() { new Moves.Bodyslam() },
		[56] = new List<Move>() { new Moves.Muddywater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderbolt() };
	public override int Weight => 175;
	public override int ExpYield => 158;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}