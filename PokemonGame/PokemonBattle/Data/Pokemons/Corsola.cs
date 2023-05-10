using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Corsola : Pokemon
{
	public override string Name => "Corsola";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle(), new Abilities.Naturalcure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(65, 55, 95, 65, 95, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[5] = new List<Move>() { new Moves.Watergun() },
		[10] = new List<Move>() { new Moves.Aquaring() },
		[15] = new List<Move>() { new Moves.Endure() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[25] = new List<Move>() { new Moves.Bubblebeam() },
		[30] = new List<Move>() { new Moves.Flail() },
		[35] = new List<Move>() { new Moves.Lifedew() },
		[40] = new List<Move>() { new Moves.Powergem() },
		[45] = new List<Move>() { new Moves.Earthpower() },
		[50] = new List<Move>() { new Moves.Recover() },
		[55] = new List<Move>() { new Moves.Mirrorcoat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Aquaring(), new Moves.Confuseray(), new Moves.Curse(), new Moves.Headsmash(), new Moves.Iciclespear(), new Moves.Ingrain(), new Moves.Liquidation(), new Moves.Mist(), new Moves.Naturepower(), new Moves.Screech() };
	public override int Weight => 50;
	public override int ExpYield => 144;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}