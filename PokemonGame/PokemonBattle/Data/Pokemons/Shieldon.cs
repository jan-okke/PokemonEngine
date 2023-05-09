using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shieldon : Pokemon
{
	public override string Name => "Shieldon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Soundproof() };
	public override Stats BaseStats => new Stats(30, 42, 118, 42, 88, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Protect() },
		[6] = new List<Move>() { new Moves.Taunt() },
		[10] = new List<Move>() { new Moves.Metalsound() },
		[15] = new List<Move>() { new Moves.Takedown() },
		[19] = new List<Move>() { new Moves.Irondefense() },
		[24] = new List<Move>() { new Moves.Swagger() },
		[28] = new List<Move>() { new Moves.Ancientpower() },
		[33] = new List<Move>() { new Moves.Endure() },
		[37] = new List<Move>() { new Moves.Metalburst() },
		[42] = new List<Move>() { new Moves.Ironhead() },
		[46] = new List<Move>() { new Moves.Heavyslam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Torment() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Counter(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Focusenergy(), new Moves.Guardsplit(), new Moves.Headbutt(), new Moves.Rockblast(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Wideguard() };
	public override int Weight => 570;
	public override int ExpYield => 70;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}