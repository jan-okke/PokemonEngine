using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lickitung : Pokemon
	{
		public override string Name => "Lickitung";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cloudnine() };
		public override Stats BaseStats => new Stats(90, 55, 75, 30, 60, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lick(), new Defensecurl() },
			[6] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Supersonic() },
			[18] = new List<Move>() { new Wrap() },
			[24] = new List<Move>() { new Disable() },
			[30] = new List<Move>() { new Stomp() },
			[36] = new List<Move>() { new Knockoff() },
			[42] = new List<Move>() { new Screech() },
			[48] = new List<Move>() { new Slam() },
			[54] = new List<Move>() { new Powerwhip() },
			[60] = new List<Move>() { new Bellydrum() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Megakick(), new Megapunch(), new Muddywater(), new Powerwhip(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Screech(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelroller(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swordsdance(), new Terrainpulse(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Waterpulse(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Belch(), new Bellydrum(), new Bodyslam(), new Curse(), new Hammerarm(), new Muddywater(), new Snore(), new Thrash(), new Zenheadbutt() };
		public override int Weight => 655;
		public override int ExpYield => 77;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}