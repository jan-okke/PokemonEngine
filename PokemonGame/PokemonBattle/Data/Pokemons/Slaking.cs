using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Slaking : Pokemon
{
	public override string Name => "Slaking";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Truant() };
	public override Stats BaseStats => new Stats(150, 160, 100, 95, 65, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Swagger() },
		[1] = new List<Move>() { new Moves.Swagger(), new Moves.Hammerarm(), new Moves.Fling(), new Moves.Scratch(), new Moves.Yawn(), new Moves.Encore(), new Moves.Slackoff() },
		[6] = new List<Move>() { new Moves.Encore() },
		[9] = new List<Move>() { new Moves.Slackoff() },
		[14] = new List<Move>() { new Moves.Rest() },
		[17] = new List<Move>() { new Moves.Amnesia() },
		[23] = new List<Move>() { new Moves.Covet() },
		[27] = new List<Move>() { new Moves.Headbutt() },
		[33] = new List<Move>() { new Moves.Counter() },
		[39] = new List<Move>() { new Moves.Flail() },
		[47] = new List<Move>() { new Moves.Fling() },
		[53] = new List<Move>() { new Moves.Suckerpunch() },
		[61] = new List<Move>() { new Moves.Hammerarm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Quash(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 1305;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}