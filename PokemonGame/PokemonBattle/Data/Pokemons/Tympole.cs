using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tympole : Pokemon
{
	public override string Name => "Tympole";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(50, 50, 40, 50, 40, 64);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Echoedvoice(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Acid() },
		[8] = new List<Move>() { new Moves.Supersonic() },
		[12] = new List<Move>() { new Moves.Mudshot() },
		[16] = new List<Move>() { new Moves.Round() },
		[20] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Flail() },
		[28] = new List<Move>() { new Moves.Uproar() },
		[32] = new List<Move>() { new Moves.Aquaring() },
		[36] = new List<Move>() { new Moves.Hypervoice() },
		[40] = new List<Move>() { new Moves.Muddywater() },
		[44] = new List<Move>() { new Moves.Raindance() },
		[48] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Weatherball() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Mist(), new Moves.Mudslap(), new Moves.Toxic(), new Moves.Waterpulse() };
	public override int Weight => 45;
	public override int ExpYield => 59;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}