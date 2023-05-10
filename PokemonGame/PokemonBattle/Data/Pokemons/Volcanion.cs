using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Volcanion : Pokemon
{
	public override string Name => "Volcanion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(80, 110, 120, 130, 90, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Firespin(), new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Leer() },
		[12] = new List<Move>() { new Moves.Weatherball() },
		[18] = new List<Move>() { new Moves.Flamecharge() },
		[24] = new List<Move>() { new Moves.Waterpulse() },
		[30] = new List<Move>() { new Moves.Scaryface() },
		[36] = new List<Move>() { new Moves.Incinerate() },
		[42] = new List<Move>() { new Moves.Stomp() },
		[48] = new List<Move>() { new Moves.Scald() },
		[54] = new List<Move>() { new Moves.Takedown() },
		[60] = new List<Move>() { new Moves.Mist(), new Moves.Haze() },
		[66] = new List<Move>() { new Moves.Hydropump() },
		[72] = new List<Move>() { new Moves.Steameruption() },
		[78] = new List<Move>() { new Moves.Flareblitz() },
		[84] = new List<Move>() { new Moves.Overheat() },
		[90] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Liquidation(), new Moves.Mistyterrain(), new Moves.Mudshot(), new Moves.Overheat(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Thunderfang(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override int Weight => 1950;
	public override int ExpYield => 300;
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