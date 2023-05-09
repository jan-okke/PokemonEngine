using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Banette : Pokemon
{
	public override string Name => "Banette";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
	public override Stats BaseStats => new Stats(64, 115, 65, 83, 63, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Phantomforce(), new Moves.Knockoff(), new Moves.Screech(), new Moves.Nightshade(), new Moves.Spite() },
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
		[40] = new List<Move>() { new Moves.Suckerpunch() },
		[46] = new List<Move>() { new Moves.Knockoff() },
		[52] = new List<Move>() { new Moves.Grudge() },
		[58] = new List<Move>() { new Moves.Trick() },
		[64] = new List<Move>() { new Moves.Phantomforce() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp() };
	public override int Weight => 125;
	public override int ExpYield => 159;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}