using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Jolteon : Pokemon
{
	public override string Name => "Jolteon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Voltabsorb() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Quickfeet() };
	public override Stats BaseStats => new Stats(65, 65, 60, 110, 95, 130);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thundershock() },
		[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Covet(), new Moves.Swift(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Thunderwave() },
		[25] = new List<Move>() { new Moves.Doublekick() },
		[30] = new List<Move>() { new Moves.Thunderfang() },
		[35] = new List<Move>() { new Moves.Pinmissile() },
		[40] = new List<Move>() { new Moves.Discharge() },
		[45] = new List<Move>() { new Moves.Agility() },
		[50] = new List<Move>() { new Moves.Thunder() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Payday(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Weatherball(), new Moves.Wildcharge(), new Moves.Workup() };
	public override int Weight => 245;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
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