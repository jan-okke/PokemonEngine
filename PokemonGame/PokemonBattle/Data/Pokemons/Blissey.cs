using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blissey : Pokemon
	{
		public override string Name => "Blissey";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Healer() };
		public override Stats BaseStats => new Stats(255, 10, 10, 75, 135, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sweetkiss(), new Moves.Disarmingvoice(), new Moves.Covet(), new Moves.Charm(), new Moves.Minimize(), new Moves.Pound(), new Moves.Copycat(), new Moves.Defensecurl() },
			[4] = new List<Move>() { new Moves.Tailwhip() },
			[8] = new List<Move>() { new Moves.Echoedvoice() },
			[12] = new List<Move>() { new Moves.Lifedew() },
			[16] = new List<Move>() { new Moves.Sing() },
			[20] = new List<Move>() { new Moves.Fling() },
			[24] = new List<Move>() { new Moves.Takedown() },
			[28] = new List<Move>() { new Moves.Healpulse() },
			[32] = new List<Move>() { new Moves.Helpinghand() },
			[36] = new List<Move>() { new Moves.Lightscreen() },
			[40] = new List<Move>() { new Moves.Doubleedge() },
			[44] = new List<Move>() { new Moves.Softboiled() },
			[48] = new List<Move>() { new Moves.Lastresort() },
			[52] = new List<Move>() { new Moves.Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 468;
		public override int ExpYield => 635;
		public override int CatchRate => 30;
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