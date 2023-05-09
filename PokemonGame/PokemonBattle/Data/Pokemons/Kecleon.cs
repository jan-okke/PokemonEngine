using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kecleon : Pokemon
{
	public override string Name => "Kecleon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Colorchange() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Protean() };
	public override Stats BaseStats => new Stats(60, 90, 70, 60, 120, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thief(), new Moves.Tailwhip(), new Moves.Astonish(), new Moves.Lick(), new Moves.Scratch() },
		[4] = new List<Move>() { new Moves.Bind() },
		[7] = new List<Move>() { new Moves.Shadowsneak() },
		[10] = new List<Move>() { new Moves.Feint() },
		[13] = new List<Move>() { new Moves.Furyswipes() },
		[16] = new List<Move>() { new Moves.Disable() },
		[18] = new List<Move>() { new Moves.Psybeam() },
		[21] = new List<Move>() { new Moves.Ancientpower() },
		[25] = new List<Move>() { new Moves.Slash() },
		[30] = new List<Move>() { new Moves.Detect() },
		[33] = new List<Move>() { new Moves.Shadowclaw() },
		[38] = new List<Move>() { new Moves.Screech() },
		[42] = new List<Move>() { new Moves.Substitute() },
		[46] = new List<Move>() { new Moves.Suckerpunch() },
		[50] = new List<Move>() { new Moves.Foulplay() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Magiccoat(), new Moves.Nastyplot(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Disable(), new Moves.Fakeout(), new Moves.Foulplay(), new Moves.Magiccoat(), new Moves.Poweruppunch(), new Moves.Recover(), new Moves.Trick() };
	public override int Weight => 220;
	public override int ExpYield => 154;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}