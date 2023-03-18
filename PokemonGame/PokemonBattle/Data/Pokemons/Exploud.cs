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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
		public override Stats BaseStats => new Stats(104, 91, 63, 91, 73, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Crunch() },
			[1] = new List<Move>() { new Moves.Crunch(), new Moves.Bite(), new Moves.Icefang(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Astonish(), new Moves.Pound(), new Moves.Echoedvoice(), new Moves.Howl() },
			[15] = new List<Move>() { new Moves.Rest(), new Moves.Sleeptalk() },
			[23] = new List<Move>() { new Moves.Stomp() },
			[29] = new List<Move>() { new Moves.Roar() },
			[36] = new List<Move>() { new Moves.Supersonic() },
			[45] = new List<Move>() { new Moves.Uproar() },
			[54] = new List<Move>() { new Moves.Screech() },
			[63] = new List<Move>() { new Moves.Hypervoice() },
			[72] = new List<Move>() { new Moves.Boomburst() },
			[81] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Terrainpulse(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup(), new Moves.Zenheadbutt() };
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