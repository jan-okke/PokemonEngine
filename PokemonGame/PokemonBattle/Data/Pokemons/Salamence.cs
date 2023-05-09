using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Salamence : Pokemon
{
	public override string Name => "Salamence";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
	public override Stats BaseStats => new Stats(95, 135, 80, 110, 80, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Fly() },
		[1] = new List<Move>() { new Moves.Fly(), new Moves.Protect(), new Moves.Dragontail(), new Moves.Ember(), new Moves.Leer(), new Moves.Bite(), new Moves.Dragonbreath() },
		[15] = new List<Move>() { new Moves.Headbutt() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[25] = new List<Move>() { new Moves.Crunch() },
		[33] = new List<Move>() { new Moves.Dragonclaw() },
		[39] = new List<Move>() { new Moves.Zenheadbutt() },
		[46] = new List<Move>() { new Moves.Focusenergy() },
		[55] = new List<Move>() { new Moves.Flamethrower() },
		[64] = new List<Move>() { new Moves.Outrage() },
		[73] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderfang(), new Moves.Zenheadbutt() };
	public override int Weight => 1026;
	public override int ExpYield => 300;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}