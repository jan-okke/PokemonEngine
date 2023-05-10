using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Armaldo : Pokemon
{
	public override string Name => "Armaldo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
	public override Stats BaseStats => new Stats(75, 125, 100, 70, 80, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Harden(), new Moves.Watergun(), new Moves.Smackdown() },
		[12] = new List<Move>() { new Moves.Metalclaw() },
		[16] = new List<Move>() { new Moves.Ancientpower() },
		[20] = new List<Move>() { new Moves.Bugbite() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Slash() },
		[32] = new List<Move>() { new Moves.Crushclaw() },
		[36] = new List<Move>() { new Moves.Rockblast() },
		[43] = new List<Move>() { new Moves.Protect() },
		[48] = new List<Move>() { new Moves.Xscissor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Waterpulse(), new Moves.Xscissor() };
	public override int Weight => 682;
	public override int ExpYield => 173;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}