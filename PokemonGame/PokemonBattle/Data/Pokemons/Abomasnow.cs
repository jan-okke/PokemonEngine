using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Abomasnow : Pokemon
{
	public override string Name => "Abomasnow";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Snowwarning() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Soundproof() };
	public override Stats BaseStats => new Stats(90, 92, 75, 92, 85, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Icepunch() },
		[1] = new List<Move>() { new Moves.Icepunch(), new Moves.Auroraveil(), new Moves.Powdersnow(), new Moves.Leer(), new Moves.Leafage(), new Moves.Mist() },
		[15] = new List<Move>() { new Moves.Iceshard() },
		[20] = new List<Move>() { new Moves.Razorleaf() },
		[25] = new List<Move>() { new Moves.Icywind() },
		[30] = new List<Move>() { new Moves.Swagger() },
		[35] = new List<Move>() { new Moves.Ingrain() },
		[43] = new List<Move>() { new Moves.Woodhammer() },
		[49] = new List<Move>() { new Moves.Blizzard() },
		[56] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Waterpulse(), new Moves.Weatherball() };
	public override int Weight => 1355;
	public override int ExpYield => 173;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}