using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Minior : Pokemon
{
	public override string Name => "Minior";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shieldsdown() };
	public override Stats BaseStats => new Stats(60, 60, 100, 60, 100, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Defensecurl() },
		[8] = new List<Move>() { new Moves.Rollout() },
		[10] = new List<Move>() { new Moves.Confuseray() },
		[15] = new List<Move>() { new Moves.Swift() },
		[17] = new List<Move>() { new Moves.Ancientpower() },
		[22] = new List<Move>() { new Moves.Selfdestruct() },
		[24] = new List<Move>() { new Moves.Stealthrock() },
		[29] = new List<Move>() { new Moves.Takedown() },
		[31] = new List<Move>() { new Moves.Autotomize() },
		[36] = new List<Move>() { new Moves.Cosmicpower() },
		[38] = new List<Move>() { new Moves.Powergem() },
		[43] = new List<Move>() { new Moves.Doubleedge() },
		[45] = new List<Move>() { new Moves.Shellsmash() },
		[50] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Explosion(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gravity(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Zenheadbutt() };
	public override int Weight => 400;
	public override int ExpYield => 154;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}