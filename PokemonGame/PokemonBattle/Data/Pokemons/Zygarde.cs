using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zygarde : Pokemon
{
	public override string Name => "Zygarde";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Aurabreak(), new Abilities.Powerconstruct() };
	public override Stats BaseStats => new Stats(108, 100, 121, 81, 95, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thousandarrows(), new Moves.Thousandwaves(), new Moves.Coreenforcer(), new Moves.Bind(), new Moves.Bulldoze(), new Moves.Dragonbreath(), new Moves.Bite() },
		[8] = new List<Move>() { new Moves.Haze() },
		[16] = new List<Move>() { new Moves.Dig() },
		[24] = new List<Move>() { new Moves.Safeguard() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[48] = new List<Move>() { new Moves.Landswrath() },
		[56] = new List<Move>() { new Moves.Glare() },
		[64] = new List<Move>() { new Moves.Sandstorm() },
		[72] = new List<Move>() { new Moves.Coil() },
		[80] = new List<Move>() { new Moves.Earthquake() },
		[88] = new List<Move>() { new Moves.Outrage() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scorchingsands(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Zenheadbutt() };
	public override int Weight => 3050;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}