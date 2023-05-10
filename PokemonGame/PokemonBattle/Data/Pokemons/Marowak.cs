using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Marowak : Pokemon
{
	public override string Name => "Marowak";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead(), new Abilities.Lightningrod() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Battlearmor() };
	public override Stats BaseStats => new Stats(60, 80, 110, 50, 80, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Growl(), new Moves.Tailwhip(), new Moves.Falseswipe() },
		[12] = new List<Move>() { new Moves.Headbutt() },
		[16] = new List<Move>() { new Moves.Retaliate() },
		[20] = new List<Move>() { new Moves.Fling() },
		[24] = new List<Move>() { new Moves.Stompingtantrum() },
		[31] = new List<Move>() { new Moves.Bonerush() },
		[36] = new List<Move>() { new Moves.Focusenergy() },
		[42] = new List<Move>() { new Moves.Endeavor() },
		[48] = new List<Move>() { new Moves.Bonemerang() },
		[54] = new List<Move>() { new Moves.Thrash() },
		[60] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uproar() };
	public override int Weight => 450;
	public override int ExpYield => 149;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}