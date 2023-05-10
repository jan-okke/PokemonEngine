using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Goomy : Pokemon
{
	public override string Name => "Goomy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sapsipper(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gooey() };
	public override Stats BaseStats => new Stats(45, 50, 35, 55, 75, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Watergun() },
		[10] = new List<Move>() { new Moves.Dragonbreath() },
		[15] = new List<Move>() { new Moves.Protect() },
		[20] = new List<Move>() { new Moves.Flail() },
		[25] = new List<Move>() { new Moves.Waterpulse() },
		[30] = new List<Move>() { new Moves.Raindance() },
		[35] = new List<Move>() { new Moves.Dragonpulse() },
		[41] = new List<Move>() { new Moves.Curse() },
		[45] = new List<Move>() { new Moves.Bodyslam() },
		[50] = new List<Move>() { new Moves.Muddywater() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderbolt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Lifedew() };
	public override int Weight => 28;
	public override int ExpYield => 60;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}