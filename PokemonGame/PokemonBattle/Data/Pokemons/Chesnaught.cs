using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chesnaught : Pokemon
	{
		public override string Name => "Chesnaught";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bulletproof() };
		public override Stats BaseStats => new Stats(88, 107, 122, 74, 75, 64);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Spikyshield() },
			[1] = new List<Move>() { new Spikyshield(), new Needlearm(), new Hammerarm(), new Feint(), new Bellydrum(), new Tackle(), new Growl(), new Vinewhip(), new Rollout() },
			[5] = new List<Move>() { new Vinewhip() },
			[8] = new List<Move>() { new Rollout() },
			[11] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Leechseed() },
			[19] = new List<Move>() { new Pinmissile() },
			[29] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Seedbomb() },
			[41] = new List<Move>() { new Mudshot() },
			[48] = new List<Move>() { new Bulkup() },
			[54] = new List<Move>() { new Bodyslam() },
			[60] = new List<Move>() { new Painsplit() },
			[66] = new List<Move>() { new Woodhammer() },
			[72] = new List<Move>() { new Hammerarm() },
			[78] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Block(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Cut(), new Doubleteam(), new Dragonclaw(), new Drainpunch(), new Dualchop(), new Earthquake(), new Endeavor(), new Energyball(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Frenzyplant(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Lowsweep(), new Naturepower(), new Painsplit(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Reflect(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Smackdown(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Taunt(), new Thunderpunch(), new Toxic(), new Workup(), new Worryseed(), new Zenheadbutt() };
		public override int Weight => 900;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}