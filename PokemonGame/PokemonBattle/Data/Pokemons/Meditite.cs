using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Meditite : Pokemon
{
	public override string Name => "Meditite";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Purepower() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(30, 40, 55, 40, 55, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound() },
		[4] = new List<Move>() { new Moves.Lowkick() },
		[7] = new List<Move>() { new Moves.Confusion() },
		[9] = new List<Move>() { new Moves.Detect() },
		[12] = new List<Move>() { new Moves.Endure() },
		[15] = new List<Move>() { new Moves.Feint() },
		[17] = new List<Move>() { new Moves.Forcepalm() },
		[20] = new List<Move>() { new Moves.Psybeam() },
		[23] = new List<Move>() { new Moves.Calmmind() },
		[25] = new List<Move>() { new Moves.Mindreader() },
		[28] = new List<Move>() { new Moves.Highjumpkick() },
		[31] = new List<Move>() { new Moves.Psychup() },
		[33] = new List<Move>() { new Moves.Acupressure() },
		[36] = new List<Move>() { new Moves.Powertrick() },
		[39] = new List<Move>() { new Moves.Reversal() },
		[41] = new List<Move>() { new Moves.Recover() },
		[44] = new List<Move>() { new Moves.Counter() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magiccoat(), new Moves.Painsplit(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Thunderpunch(), new Moves.Trick(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Bulletpunch(), new Moves.Dynamicpunch(), new Moves.Fakeout(), new Moves.Firepunch(), new Moves.Guardswap(), new Moves.Icepunch(), new Moves.Powerswap(), new Moves.Psychocut(), new Moves.Quickguard(), new Moves.Thunderpunch() };
	public override int Weight => 112;
	public override int ExpYield => 56;
	public override int CatchRate => 180;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}