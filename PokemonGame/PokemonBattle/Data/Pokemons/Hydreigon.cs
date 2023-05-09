using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hydreigon : Pokemon
{
	public override string Name => "Hydreigon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(92, 105, 90, 125, 90, 98);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Doublehit(), new Moves.Triattack(), new Moves.Focusenergy(), new Moves.Dragonbreath(), new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Roar() },
		[16] = new List<Move>() { new Moves.Assurance() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Workup() },
		[28] = new List<Move>() { new Moves.Slam() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Scaryface() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[44] = new List<Move>() { new Moves.Bodyslam() },
		[48] = new List<Move>() { new Moves.Hypervoice() },
		[54] = new List<Move>() { new Moves.Dragonrush() },
		[60] = new List<Move>() { new Moves.Nastyplot() },
		[68] = new List<Move>() { new Moves.Outrage() },
		[76] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 1600;
	public override int ExpYield => 300;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}