using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lickilicky : Pokemon
{
	public override string Name => "Lickilicky";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Oblivious() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cloudnine() };
	public override Stats BaseStats => new Stats(110, 85, 95, 80, 95, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Lick(), new Moves.Defensecurl(), new Moves.Rollout(), new Moves.Supersonic() },
		[18] = new List<Move>() { new Moves.Wrap() },
		[24] = new List<Move>() { new Moves.Disable() },
		[30] = new List<Move>() { new Moves.Stomp() },
		[36] = new List<Move>() { new Moves.Knockoff() },
		[42] = new List<Move>() { new Moves.Screech() },
		[48] = new List<Move>() { new Moves.Slam() },
		[54] = new List<Move>() { new Moves.Powerwhip() },
		[60] = new List<Move>() { new Moves.Bellydrum() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 1400;
	public override int ExpYield => 180;
	public override int CatchRate => 30;
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