using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Palpitoad : Pokemon
{
	public override string Name => "Palpitoad";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(75, 65, 55, 65, 55, 69);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Echoedvoice(), new Moves.Growl(), new Moves.Acid(), new Moves.Supersonic() },
		[12] = new List<Move>() { new Moves.Mudshot() },
		[16] = new List<Move>() { new Moves.Round() },
		[20] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Flail() },
		[30] = new List<Move>() { new Moves.Uproar() },
		[37] = new List<Move>() { new Moves.Aquaring() },
		[42] = new List<Move>() { new Moves.Hypervoice() },
		[48] = new List<Move>() { new Moves.Muddywater() },
		[54] = new List<Move>() { new Moves.Raindance() },
		[60] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Surf(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Weatherball() };
	public override int Weight => 170;
	public override int ExpYield => 134;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}