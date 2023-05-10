using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Chesnaught : Pokemon
{
	public override string Name => "Chesnaught";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bulletproof() };
	public override Stats BaseStats => new Stats(88, 107, 122, 74, 75, 64);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Spikyshield() },
		[1] = new List<Move>() { new Moves.Spikyshield(), new Moves.Needlearm(), new Moves.Hammerarm(), new Moves.Feint(), new Moves.Bellydrum(), new Moves.Tackle(), new Moves.Growl(), new Moves.Vinewhip(), new Moves.Rollout() },
		[5] = new List<Move>() { new Moves.Vinewhip() },
		[8] = new List<Move>() { new Moves.Rollout() },
		[11] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Leechseed() },
		[19] = new List<Move>() { new Moves.Pinmissile() },
		[29] = new List<Move>() { new Moves.Takedown() },
		[35] = new List<Move>() { new Moves.Seedbomb() },
		[41] = new List<Move>() { new Moves.Mudshot() },
		[48] = new List<Move>() { new Moves.Bulkup() },
		[54] = new List<Move>() { new Moves.Bodyslam() },
		[60] = new List<Move>() { new Moves.Painsplit() },
		[66] = new List<Move>() { new Moves.Woodhammer() },
		[72] = new List<Move>() { new Moves.Hammerarm() },
		[78] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Drainpunch(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frenzyplant(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Naturepower(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Workup(), new Moves.Worryseed(), new Moves.Zenheadbutt() };
	public override int Weight => 900;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 3,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}