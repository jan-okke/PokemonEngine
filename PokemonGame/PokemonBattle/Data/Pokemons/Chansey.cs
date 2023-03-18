using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chansey : Pokemon
	{
		public override string Name => "Chansey";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Healer() };
		public override Stats BaseStats => new Stats(250, 5, 5, 35, 105, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sweetkiss(), new Disarmingvoice(), new Covet(), new Charm(), new Minimize(), new Pound(), new Copycat(), new Defensecurl() },
			[4] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Echoedvoice() },
			[12] = new List<Move>() { new Lifedew() },
			[16] = new List<Move>() { new Sing() },
			[20] = new List<Move>() { new Fling() },
			[24] = new List<Move>() { new Takedown() },
			[28] = new List<Move>() { new Healpulse() },
			[32] = new List<Move>() { new Helpinghand() },
			[36] = new List<Move>() { new Lightscreen() },
			[40] = new List<Move>() { new Doubleedge() },
			[44] = new List<Move>() { new Softboiled() },
			[48] = new List<Move>() { new Lastresort() },
			[52] = new List<Move>() { new Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focuspunch(), new Gigaimpact(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Metronome(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Triattack(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Aromatherapy(), new Counter(), new Gravity(), new Healbell(), new Helpinghand(), new Metronome(), new Present(), new Seismictoss() };
		public override int Weight => 346;
		public override int ExpYield => 395;
		public override int CatchRate => 30;
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