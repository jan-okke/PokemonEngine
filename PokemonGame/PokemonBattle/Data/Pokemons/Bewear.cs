using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bewear : Pokemon
{
	public override string Name => "Bewear";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Fluffy(), new Abilities.Klutz() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(120, 125, 80, 55, 60, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Bind() },
		[1] = new List<Move>() { new Moves.Bind(), new Moves.Tackle(), new Moves.Leer(), new Moves.Babydolleyes(), new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Brutalswing() },
		[16] = new List<Move>() { new Moves.Endure() },
		[20] = new List<Move>() { new Moves.Strength() },
		[24] = new List<Move>() { new Moves.Takedown() },
		[30] = new List<Move>() { new Moves.Flail() },
		[36] = new List<Move>() { new Moves.Hammerarm() },
		[42] = new List<Move>() { new Moves.Thrash() },
		[48] = new List<Move>() { new Moves.Painsplit() },
		[54] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Darkestlariat(), new Moves.Dragonclaw(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 1350;
	public override int ExpYield => 175;
	public override int CatchRate => 70;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}