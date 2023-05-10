using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dialga : Pokemon
{
	public override string Name => "Dialga";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(100, 120, 120, 150, 100, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scaryface(), new Moves.Metalclaw() },
		[8] = new List<Move>() { new Moves.Dragonbreath() },
		[16] = new List<Move>() { new Moves.Ancientpower() },
		[24] = new List<Move>() { new Moves.Slash() },
		[32] = new List<Move>() { new Moves.Flashcannon() },
		[40] = new List<Move>() { new Moves.Roaroftime() },
		[48] = new List<Move>() { new Moves.Dragonclaw() },
		[56] = new List<Move>() { new Moves.Aurasphere() },
		[64] = new List<Move>() { new Moves.Powergem() },
		[72] = new List<Move>() { new Moves.Metalburst() },
		[80] = new List<Move>() { new Moves.Earthpower() },
		[88] = new List<Move>() { new Moves.Irontail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aurasphere(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trickroom() };
	public override int Weight => 6830;
	public override int ExpYield => 340;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}