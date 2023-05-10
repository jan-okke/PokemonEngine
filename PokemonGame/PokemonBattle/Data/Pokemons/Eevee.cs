using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Eevee : Pokemon
{
	public override string Name => "Eevee";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Adaptability() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Anticipation() };
	public override Stats BaseStats => new Stats(55, 55, 50, 45, 65, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Covet(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Swift() },
		[25] = new List<Move>() { new Moves.Bite() },
		[30] = new List<Move>() { new Moves.Copycat() },
		[35] = new List<Move>() { new Moves.Batonpass() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[45] = new List<Move>() { new Moves.Charm() },
		[50] = new List<Move>() { new Moves.Doubleedge() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Payday(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Weatherball(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Charm(), new Moves.Covet(), new Moves.Curse(), new Moves.Detect(), new Moves.Doublekick(), new Moves.Faketears(), new Moves.Flail(), new Moves.Mudslap(), new Moves.Storedpower(), new Moves.Tickle(), new Moves.Wish(), new Moves.Yawn() };
	public override int Weight => 65;
	public override int ExpYield => 65;
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