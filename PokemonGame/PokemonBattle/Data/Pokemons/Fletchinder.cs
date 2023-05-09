using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Fletchinder : Pokemon
{
	public override string Name => "Fletchinder";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Galewings() };
	public override Stats BaseStats => new Stats(62, 73, 55, 56, 52, 84);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Flamecharge() },
		[1] = new List<Move>() { new Moves.Flamecharge(), new Moves.Feint(), new Moves.Peck(), new Moves.Growl(), new Moves.Quickattack(), new Moves.Ember() },
		[15] = new List<Move>() { new Moves.Flail() },
		[22] = new List<Move>() { new Moves.Acrobatics() },
		[29] = new List<Move>() { new Moves.Agility() },
		[36] = new List<Move>() { new Moves.Aerialace() },
		[43] = new List<Move>() { new Moves.Tailwind() },
		[50] = new List<Move>() { new Moves.Steelwing() },
		[57] = new List<Move>() { new Moves.Roost() },
		[64] = new List<Move>() { new Moves.Fly() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Attract(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
	public override int Weight => 160;
	public override int ExpYield => 134;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}