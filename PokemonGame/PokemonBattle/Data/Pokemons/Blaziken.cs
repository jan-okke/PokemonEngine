using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Blaziken : Pokemon
{
	public override string Name => "Blaziken";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Speedboost() };
	public override Stats BaseStats => new Stats(80, 120, 70, 110, 70, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Closecombat(), new Moves.Doublekick(), new Moves.Firepunch(), new Moves.Bravebird(), new Moves.Flamethrower(), new Moves.Featherdance(), new Moves.Scratch(), new Moves.Growl(), new Moves.Ember(), new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Flamecharge() },
		[12] = new List<Move>() { new Moves.Detect() },
		[15] = new List<Move>() { new Moves.Sandattack() },
		[20] = new List<Move>() { new Moves.Aerialace() },
		[25] = new List<Move>() { new Moves.Slash() },
		[30] = new List<Move>() { new Moves.Bounce() },
		[35] = new List<Move>() { new Moves.Focusenergy() },
		[42] = new List<Move>() { new Moves.Blazekick() },
		[49] = new List<Move>() { new Moves.Bulkup() },
		[56] = new List<Move>() { new Moves.Reversal() },
		[63] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Blastburn(), new Moves.Blazekick(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Bravebird(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Overheat(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thunderpunch(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
	public override int Weight => 520;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}