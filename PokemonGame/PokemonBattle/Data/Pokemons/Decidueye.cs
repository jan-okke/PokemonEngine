using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Decidueye : Pokemon
{
	public override string Name => "Decidueye";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Longreach() };
	public override Stats BaseStats => new Stats(78, 107, 75, 100, 100, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Spiritshackle() },
		[1] = new List<Move>() { new Moves.Spiritshackle(), new Moves.Phantomforce(), new Moves.Leafstorm(), new Moves.Uturn(), new Moves.Spite(), new Moves.Tackle(), new Moves.Growl(), new Moves.Leafage(), new Moves.Astonish() },
		[9] = new List<Move>() { new Moves.Peck() },
		[12] = new List<Move>() { new Moves.Shadowsneak() },
		[15] = new List<Move>() { new Moves.Razorleaf() },
		[20] = new List<Move>() { new Moves.Synthesis() },
		[25] = new List<Move>() { new Moves.Pluck() },
		[30] = new List<Move>() { new Moves.Nastyplot() },
		[37] = new List<Move>() { new Moves.Suckerpunch() },
		[44] = new List<Move>() { new Moves.Leafblade() },
		[51] = new List<Move>() { new Moves.Featherdance() },
		[58] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bravebird(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Frenzyplant(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Lowsweep(), new Moves.Nastyplot(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 366;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}