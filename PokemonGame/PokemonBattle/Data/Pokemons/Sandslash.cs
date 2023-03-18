using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sandslash : Pokemon
	{
		public override string Name => "Sandslash";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandrush() };
		public override Stats BaseStats => new Stats(75, 100, 110, 65, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Crushclaw(), new Scratch(), new Defensecurl(), new Poisonsting(), new Sandattack() },
			[9] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Furycutter() },
			[15] = new List<Move>() { new Rapidspin() },
			[18] = new List<Move>() { new Bulldoze() },
			[21] = new List<Move>() { new Swift() },
			[26] = new List<Move>() { new Furyswipes() },
			[31] = new List<Move>() { new Sandtomb() },
			[36] = new List<Move>() { new Slash() },
			[41] = new List<Move>() { new Dig() },
			[46] = new List<Move>() { new Gyroball() },
			[51] = new List<Move>() { new Swordsdance() },
			[56] = new List<Move>() { new Sandstorm() },
			[61] = new List<Move>() { new Earthquake() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Amnesia(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Leechlife(), new Mudshot(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Throatchop(), new Workup(), new Xscissor() };
		public override int Weight => 295;
		public override int ExpYield => 158;
		public override int CatchRate => 90;
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