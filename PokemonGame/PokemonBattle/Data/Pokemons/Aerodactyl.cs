using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aerodactyl : Pokemon
{
	public override string Name => "Aerodactyl";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead(), new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(80, 105, 65, 60, 75, 130);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bite(), new Moves.Ancientpower() },
		[5] = new List<Move>() { new Moves.Supersonic() },
		[10] = new List<Move>() { new Moves.Wingattack() },
		[15] = new List<Move>() { new Moves.Scaryface() },
		[20] = new List<Move>() { new Moves.Rockslide() },
		[25] = new List<Move>() { new Moves.Roar() },
		[30] = new List<Move>() { new Moves.Crunch() },
		[35] = new List<Move>() { new Moves.Ironhead() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[45] = new List<Move>() { new Moves.Stoneedge() },
		[50] = new List<Move>() { new Moves.Agility() },
		[55] = new List<Move>() { new Moves.Hyperbeam() },
		[60] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Meteorbeam(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Torment() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Curse(), new Moves.Dragonbreath(), new Moves.Tailwind(), new Moves.Whirlwind(), new Moves.Wideguard() };
	public override int Weight => 590;
	public override int ExpYield => 180;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}