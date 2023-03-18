using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Primarina : Pokemon
	{
		public override string Name => "Primarina";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Liquidvoice() };
		public override Stats BaseStats => new Stats(80, 74, 74, 126, 116, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Sparklingaria() },
			[1] = new List<Move>() { new Sparklingaria(), new Pound(), new Growl(), new Watergun(), new Disarmingvoice() },
			[9] = new List<Move>() { new Aquajet() },
			[12] = new List<Move>() { new Babydolleyes() },
			[15] = new List<Move>() { new Icywind() },
			[20] = new List<Move>() { new Sing() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Encore() },
			[37] = new List<Move>() { new Mistyterrain() },
			[44] = new List<Move>() { new Hypervoice() },
			[51] = new List<Move>() { new Moonblast() },
			[58] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Amnesia(), new Attract(), new Blizzard(), new Brine(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Dive(), new Drainingkiss(), new Encore(), new Endure(), new Energyball(), new Facade(), new Flipturn(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydrocannon(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Lightscreen(), new Liquidation(), new Mistyexplosion(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Round(), new Scald(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Surf(), new Tripleaxel(), new Uproar(), new Waterfall(), new Waterpledge(), new Weatherball(), new Whirlpool(), new Wonderroom(), new Workup() };
		public override int Weight => 440;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}