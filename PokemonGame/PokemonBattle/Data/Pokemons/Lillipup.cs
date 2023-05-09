using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lillipup : Pokemon
{
	public override string Name => "Lillipup";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Vitalspirit(), new Abilities.Pickup() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
	public override Stats BaseStats => new Stats(45, 60, 45, 25, 45, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Workup() },
		[8] = new List<Move>() { new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Retaliate() },
		[17] = new List<Move>() { new Moves.Babydolleyes() },
		[20] = new List<Move>() { new Moves.Playrough() },
		[24] = new List<Move>() { new Moves.Crunch() },
		[28] = new List<Move>() { new Moves.Takedown() },
		[32] = new List<Move>() { new Moves.Helpinghand() },
		[36] = new List<Move>() { new Moves.Reversal() },
		[40] = new List<Move>() { new Moves.Roar() },
		[44] = new List<Move>() { new Moves.Lastresort() },
		[48] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Covet(), new Moves.Howl(), new Moves.Lick(), new Moves.Mudslap(), new Moves.Yawn() };
	public override int Weight => 41;
	public override int ExpYield => 55;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}