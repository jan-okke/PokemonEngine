using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Stantler : Pokemon
{
	public override string Name => "Stantler";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
	public override Stats BaseStats => new Stats(73, 95, 62, 85, 65, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Astonish() },
		[10] = new List<Move>() { new Moves.Hypnosis() },
		[13] = new List<Move>() { new Moves.Stomp() },
		[16] = new List<Move>() { new Moves.Sandattack() },
		[21] = new List<Move>() { new Moves.Takedown() },
		[23] = new List<Move>() { new Moves.Confuseray() },
		[27] = new List<Move>() { new Moves.Calmmind() },
		[33] = new List<Move>() { new Moves.Roleplay() },
		[38] = new List<Move>() { new Moves.Zenheadbutt() },
		[43] = new List<Move>() { new Moves.Lunge() },
		[49] = new List<Move>() { new Moves.Imprison() },
		[50] = new List<Move>() { new Moves.Entrainment() },
		[55] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gravity(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bite(), new Moves.Disable(), new Moves.Doublekick(), new Moves.Extrasensory(), new Moves.Megahorn(), new Moves.Spite(), new Moves.Thrash(), new Moves.Zenheadbutt() };
	public override int Weight => 712;
	public override int ExpYield => 163;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}