using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Deoxys : Pokemon
{
	public override string Name => "Deoxys";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override Stats BaseStats => new Stats(50, 150, 50, 150, 50, 150);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leer(), new Moves.Wrap() },
		[7] = new List<Move>() { new Moves.Nightshade() },
		[13] = new List<Move>() { new Moves.Teleport() },
		[19] = new List<Move>() { new Moves.Knockoff() },
		[25] = new List<Move>() { new Moves.Toxicspikes() },
		[31] = new List<Move>() { new Moves.Psychic() },
		[37] = new List<Move>() { new Moves.Switcheroo() },
		[43] = new List<Move>() { new Moves.Psychoshift() },
		[49] = new List<Move>() { new Moves.Zenheadbutt() },
		[55] = new List<Move>() { new Moves.Cosmicpower() },
		[61] = new List<Move>() { new Moves.Recover() },
		[67] = new List<Move>() { new Moves.Psychoboost() },
		[73] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Avalanche(), new Moves.Bind(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magiccoat(), new Moves.Nastyplot(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 608;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}