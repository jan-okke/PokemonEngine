using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Umbreon : Pokemon
{
	public override string Name => "Umbreon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(95, 65, 110, 60, 130, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Snarl() },
		[1] = new List<Move>() { new Moves.Foulplay(), new Moves.Snarl(), new Moves.Covet(), new Moves.Swift(), new Moves.Bite(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Takedown(), new Moves.Charm(), new Moves.Doubleedge(), new Moves.Helpinghand(), new Moves.Tackle(), new Moves.Growl(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Confuseray() },
		[25] = new List<Move>() { new Moves.Assurance() },
		[30] = new List<Move>() { new Moves.Moonlight() },
		[35] = new List<Move>() { new Moves.Guardswap() },
		[40] = new List<Move>() { new Moves.Darkpulse() },
		[45] = new List<Move>() { new Moves.Screech() },
		[50] = new List<Move>() { new Moves.Meanlook() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Payback(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Weatherball(), new Moves.Wonderroom(), new Moves.Workup() };
	public override int Weight => 270;
	public override int ExpYield => 184;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}