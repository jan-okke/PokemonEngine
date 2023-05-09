using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tropius : Pokemon
{
	public override string Name => "Tropius";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Solarpower() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Harvest() };
	public override Stats BaseStats => new Stats(99, 68, 83, 72, 87, 51);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leafstorm(), new Moves.Leer(), new Moves.Gust(), new Moves.Growth(), new Moves.Razorleaf() },
		[6] = new List<Move>() { new Moves.Sweetscent() },
		[10] = new List<Move>() { new Moves.Stomp() },
		[16] = new List<Move>() { new Moves.Magicalleaf() },
		[21] = new List<Move>() { new Moves.Whirlwind() },
		[26] = new List<Move>() { new Moves.Leaftornado() },
		[30] = new List<Move>() { new Moves.Dragondance() },
		[36] = new List<Move>() { new Moves.Airslash() },
		[41] = new List<Move>() { new Moves.Bodyslam() },
		[46] = new List<Move>() { new Moves.Dragonhammer() },
		[50] = new List<Move>() { new Moves.Synthesis() },
		[56] = new List<Move>() { new Moves.Solarbeam() },
		[61] = new List<Move>() { new Moves.Leafstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Naturepower(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Tailwind(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Dragondance(), new Moves.Dragonhammer(), new Moves.Headbutt(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Leechseed(), new Moves.Naturepower(), new Moves.Slam(), new Moves.Synthesis() };
	public override int Weight => 1000;
	public override int ExpYield => 161;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}