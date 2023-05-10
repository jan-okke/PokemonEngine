using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tepig : Pokemon
{
	public override string Name => "Tepig";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Thickfat() };
	public override Stats BaseStats => new Stats(65, 63, 45, 45, 45, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Tailwhip() },
		[7] = new List<Move>() { new Moves.Ember() },
		[9] = new List<Move>() { new Moves.Odorsleuth() },
		[13] = new List<Move>() { new Moves.Defensecurl() },
		[15] = new List<Move>() { new Moves.Flamecharge() },
		[19] = new List<Move>() { new Moves.Smog() },
		[21] = new List<Move>() { new Moves.Rollout() },
		[25] = new List<Move>() { new Moves.Takedown() },
		[27] = new List<Move>() { new Moves.Heatcrash() },
		[31] = new List<Move>() { new Moves.Assurance() },
		[33] = new List<Move>() { new Moves.Flamethrower() },
		[37] = new List<Move>() { new Moves.Headsmash() },
		[39] = new List<Move>() { new Moves.Roar() },
		[43] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Burnup(), new Moves.Covet(), new Moves.Curse(), new Moves.Endeavor(), new Moves.Heavyslam(), new Moves.Magnitude(), new Moves.Sleeptalk(), new Moves.Suckerpunch(), new Moves.Superpower(), new Moves.Thrash(), new Moves.Yawn() };
	public override int Weight => 99;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}