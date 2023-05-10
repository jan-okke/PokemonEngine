using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Regigigas : Pokemon
{
	public override string Name => "Regigigas";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Slowstart() };
	public override Stats BaseStats => new Stats(110, 160, 110, 80, 110, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Confuseray() },
		[6] = new List<Move>() { new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Revenge() },
		[18] = new List<Move>() { new Moves.Stomp() },
		[24] = new List<Move>() { new Moves.Protect() },
		[30] = new List<Move>() { new Moves.Knockoff() },
		[36] = new List<Move>() { new Moves.Megapunch() },
		[42] = new List<Move>() { new Moves.Bodypress() },
		[48] = new List<Move>() { new Moves.Wideguard() },
		[54] = new List<Move>() { new Moves.Zenheadbutt() },
		[60] = new List<Move>() { new Moves.Heavyslam() },
		[66] = new List<Move>() { new Moves.Hammerarm() },
		[72] = new List<Move>() { new Moves.Gigaimpact() },
		[78] = new List<Move>() { new Moves.Crushgrip() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Avalanche(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Darkestlariat(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Terrainpulse(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Zenheadbutt() };
	public override int Weight => 4200;
	public override int ExpYield => 335;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}