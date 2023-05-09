using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cursola : Pokemon
{
	public override string Name => "Cursola";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Weakarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Perishbody() };
	public override Stats BaseStats => new Stats(60, 95, 50, 145, 130, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Perishsong(), new Moves.Tackle(), new Moves.Harden(), new Moves.Astonish(), new Moves.Disable() },
		[15] = new List<Move>() { new Moves.Spite() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[25] = new List<Move>() { new Moves.Hex() },
		[30] = new List<Move>() { new Moves.Curse() },
		[35] = new List<Move>() { new Moves.Strengthsap() },
		[40] = new List<Move>() { new Moves.Powergem() },
		[45] = new List<Move>() { new Moves.Nightshade() },
		[50] = new List<Move>() { new Moves.Grudge() },
		[55] = new List<Move>() { new Moves.Mirrorcoat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Pinmissile(), new Moves.Poltergeist(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Throatchop(), new Moves.Whirlpool(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Confuseray(), new Moves.Destinybond(), new Moves.Haze(), new Moves.Headsmash(), new Moves.Naturepower(), new Moves.Waterpulse() };
	public override int Weight => 4;
	public override int ExpYield => 179;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}