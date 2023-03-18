using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golurk : Pokemon
	{
		public override string Name => "Golurk";
		public override List<Ability> AvailableAbilities => new() {new Ironfist(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(89, 124, 80, 55, 55, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Highhorsepower(), new Focuspunch(), new Mudslap(), new Astonish(), new Defensecurl(), new Pound() },
			[12] = new List<Move>() { new Shadowpunch() },
			[16] = new List<Move>() { new Curse() },
			[20] = new List<Move>() { new Nightshade() },
			[24] = new List<Move>() { new Stompingtantrum() },
			[28] = new List<Move>() { new Irondefense() },
			[32] = new List<Move>() { new Megapunch() },
			[36] = new List<Move>() { new Shadowball() },
			[40] = new List<Move>() { new Heavyslam() },
			[46] = new List<Move>() { new Phantomforce() },
			[52] = new List<Move>() { new Hammerarm() },
			[58] = new List<Move>() { new Earthquake() },
			[64] = new List<Move>() { new Dynamicpunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Closecombat(), new Darkestlariat(), new Dig(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Flashcannon(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Heatcrash(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Imprison(), new Irondefense(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scorchingsands(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Trick(), new Zenheadbutt() };
		public override int Weight => 3300;
		public override int ExpYield => 169;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}