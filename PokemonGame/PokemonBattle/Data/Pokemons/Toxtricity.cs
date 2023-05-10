using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Toxtricity : Pokemon
{
	public override string Name => "Toxtricity";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Punkrock(), new Abilities.Plus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(75, 98, 70, 114, 70, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Spark() },
		[1] = new List<Move>() { new Moves.Spark(), new Moves.Eerieimpulse(), new Moves.Belch(), new Moves.Tearfullook(), new Moves.Nuzzle(), new Moves.Growl(), new Moves.Flail(), new Moves.Acid(), new Moves.Thundershock(), new Moves.Acidspray(), new Moves.Leer(), new Moves.Nobleroar() },
		[4] = new List<Move>() { new Moves.Charge() },
		[8] = new List<Move>() { new Moves.Shockwave() },
		[12] = new List<Move>() { new Moves.Scaryface() },
		[16] = new List<Move>() { new Moves.Taunt() },
		[20] = new List<Move>() { new Moves.Venoshock() },
		[24] = new List<Move>() { new Moves.Screech() },
		[28] = new List<Move>() { new Moves.Swagger() },
		[32] = new List<Move>() { new Moves.Toxic() },
		[36] = new List<Move>() { new Moves.Discharge() },
		[40] = new List<Move>() { new Moves.Poisonjab() },
		[44] = new List<Move>() { new Moves.Overdrive() },
		[48] = new List<Move>() { new Moves.Boomburst() },
		[52] = new List<Move>() { new Moves.Shiftgear() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Drainpunch(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snarl(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 400;
	public override int ExpYield => 176;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}