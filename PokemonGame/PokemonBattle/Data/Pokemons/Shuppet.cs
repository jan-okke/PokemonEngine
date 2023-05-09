using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shuppet : Pokemon
{
	public override string Name => "Shuppet";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
	public override Stats BaseStats => new Stats(44, 75, 35, 63, 33, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Knockoff() },
		[4] = new List<Move>() { new Moves.Screech() },
		[7] = new List<Move>() { new Moves.Nightshade() },
		[10] = new List<Move>() { new Moves.Spite() },
		[13] = new List<Move>() { new Moves.Shadowsneak() },
		[16] = new List<Move>() { new Moves.Willowisp() },
		[19] = new List<Move>() { new Moves.Painsplit() },
		[22] = new List<Move>() { new Moves.Hex() },
		[26] = new List<Move>() { new Moves.Curse() },
		[30] = new List<Move>() { new Moves.Shadowball() },
		[34] = new List<Move>() { new Moves.Roleplay() },
		[38] = new List<Move>() { new Moves.Suckerpunch() },
		[42] = new List<Move>() { new Moves.Knockoff() },
		[46] = new List<Move>() { new Moves.Grudge() },
		[50] = new List<Move>() { new Moves.Trick() },
		[54] = new List<Move>() { new Moves.Phantomforce() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Confuseray(), new Moves.Destinybond(), new Moves.Disable(), new Moves.Gunkshot(), new Moves.Imprison(), new Moves.Phantomforce(), new Moves.Shadowsneak() };
	public override int Weight => 23;
	public override int ExpYield => 59;
	public override int CatchRate => 225;
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