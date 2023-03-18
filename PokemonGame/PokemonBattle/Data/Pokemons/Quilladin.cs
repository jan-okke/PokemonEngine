using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Quilladin : Pokemon
	{
		public override string Name => "Quilladin";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bulletproof() };
		public override Stats BaseStats => new Stats(61, 78, 95, 57, 56, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Needlearm() },
			[1] = new List<Move>() { new Needlearm(), new Growl(), new Vinewhip() },
			[5] = new List<Move>() { new Vinewhip() },
			[8] = new List<Move>() { new Rollout() },
			[11] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Leechseed() },
			[19] = new List<Move>() { new Pinmissile() },
			[29] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Seedbomb() },
			[39] = new List<Move>() { new Mudshot() },
			[44] = new List<Move>() { new Bulkup() },
			[48] = new List<Move>() { new Bodyslam() },
			[52] = new List<Move>() { new Painsplit() },
			[56] = new List<Move>() { new Woodhammer() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Cut(), new Doubleteam(), new Drainpunch(), new Dualchop(), new Endeavor(), new Energyball(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Lowsweep(), new Naturepower(), new Painsplit(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Reflect(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Smackdown(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Swagger(), new Swordsdance(), new Synthesis(), new Taunt(), new Thunderpunch(), new Toxic(), new Workup(), new Worryseed(), new Zenheadbutt() };
		public override int Weight => 290;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}