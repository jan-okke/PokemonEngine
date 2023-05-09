using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dratini : Pokemon
{
	public override string Name => "Dratini";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Marvelscale() };
	public override Stats BaseStats => new Stats(41, 64, 45, 50, 50, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Twister() },
		[10] = new List<Move>() { new Moves.Thunderwave() },
		[15] = new List<Move>() { new Moves.Dragontail() },
		[20] = new List<Move>() { new Moves.Agility() },
		[25] = new List<Move>() { new Moves.Slam() },
		[31] = new List<Move>() { new Moves.Aquatail() },
		[35] = new List<Move>() { new Moves.Dragonrush() },
		[40] = new List<Move>() { new Moves.Safeguard() },
		[45] = new List<Move>() { new Moves.Raindance() },
		[50] = new List<Move>() { new Moves.Dragondance() },
		[55] = new List<Move>() { new Moves.Outrage() },
		[60] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaleshot(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Dragonbreath(), new Moves.Dragondance(), new Moves.Dragonrush(), new Moves.Extremespeed(), new Moves.Haze(), new Moves.Mist(), new Moves.Supersonic() };
	public override int Weight => 33;
	public override int ExpYield => 60;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}