using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Exploud : Pokemon
	{
		public override string Name => "Exploud";
		public override List<Ability> AvailableAbilities => new() {new Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(104, 91, 63, 68, 91, 73);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Crunch() },
			[1] = new List<Move>() { new Crunch(), new Bite(), new Icefang(), new Firefang(), new Thunderfang(), new Astonish(), new Pound(), new Echoedvoice(), new Howl() },
			[15] = new List<Move>() { new Rest(), new Sleeptalk() },
			[23] = new List<Move>() { new Stomp() },
			[29] = new List<Move>() { new Roar() },
			[36] = new List<Move>() { new Supersonic() },
			[45] = new List<Move>() { new Uproar() },
			[54] = new List<Move>() { new Screech() },
			[63] = new List<Move>() { new Hypervoice() },
			[72] = new List<Move>() { new Boomburst() },
			[81] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Crunch(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firefang(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Gigaimpact(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icefang(), new Icepunch(), new Icywind(), new Lowkick(), new Megakick(), new Megapunch(), new Outrage(), new Overheat(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Taunt(), new Terrainpulse(), new Thunderfang(), new Thunderpunch(), new Torment(), new Uproar(), new Waterpulse(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override int Weight => 840;
		public override int ExpYield => 245;
		public override int CatchRate => 45;
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
}