using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Talonflame : Pokemon
{
	public override string Name => "Talonflame";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Galewings() };
	public override Stats BaseStats => new Stats(78, 81, 71, 74, 69, 126);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Flamecharge(), new Moves.Flareblitz(), new Moves.Feint(), new Moves.Peck(), new Moves.Growl(), new Moves.Quickattack(), new Moves.Ember() },
		[15] = new List<Move>() { new Moves.Flail() },
		[22] = new List<Move>() { new Moves.Acrobatics() },
		[29] = new List<Move>() { new Moves.Agility() },
		[38] = new List<Move>() { new Moves.Aerialace() },
		[47] = new List<Move>() { new Moves.Tailwind() },
		[56] = new List<Move>() { new Moves.Steelwing() },
		[65] = new List<Move>() { new Moves.Roost() },
		[74] = new List<Move>() { new Moves.Fly() },
		[83] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Bulkup(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
	public override int Weight => 245;
	public override int ExpYield => 175;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}