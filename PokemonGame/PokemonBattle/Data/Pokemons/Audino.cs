using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Audino : Pokemon
	{
		public override string Name => "Audino";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Klutz() };
		public override Stats BaseStats => new Stats(103, 60, 86, 50, 60, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Playnice() },
			[4] = new List<Move>() { new Disarmingvoice() },
			[9] = new List<Move>() { new Babydolleyes() },
			[12] = new List<Move>() { new Helpinghand() },
			[16] = new List<Move>() { new Growl() },
			[20] = new List<Move>() { new Zenheadbutt() },
			[24] = new List<Move>() { new Lifedew() },
			[28] = new List<Move>() { new Afteryou() },
			[32] = new List<Move>() { new Takedown() },
			[36] = new List<Move>() { new Simplebeam() },
			[40] = new List<Move>() { new Hypervoice() },
			[44] = new List<Move>() { new Healpulse() },
			[48] = new List<Move>() { new Doubleedge() },
			[52] = new List<Move>() { new Entrainment() },
			[56] = new List<Move>() { new Mistyterrain() },
			[60] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Calmmind(), new Dazzlinggleam(), new Dig(), new Drainingkiss(), new Drainpunch(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Lowkick(), new Megakick(), new Megapunch(), new Mistyterrain(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Surf(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trickroom(), new Uproar(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Healingwish(), new Sweetkiss(), new Wish(), new Yawn() };
		public override int Weight => 310;
		public override int ExpYield => 390;
		public override int CatchRate => 255;
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