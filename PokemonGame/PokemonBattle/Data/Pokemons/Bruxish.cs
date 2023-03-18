using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bruxish : Pokemon
	{
		public override string Name => "Bruxish";
		public override List<Ability> AvailableAbilities => new() {new Dazzling(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Wonderskin() };
		public override Stats BaseStats => new Stats(68, 105, 70, 92, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun() },
			[4] = new List<Move>() { new Astonish() },
			[9] = new List<Move>() { new Confusion() },
			[12] = new List<Move>() { new Bite() },
			[17] = new List<Move>() { new Aquajet() },
			[20] = new List<Move>() { new Disable() },
			[25] = new List<Move>() { new Psywave() },
			[28] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Aquatail() },
			[36] = new List<Move>() { new Screech() },
			[41] = new List<Move>() { new Psychicfangs() },
			[44] = new List<Move>() { new Synchronoise() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Allyswitch(), new Aquatail(), new Attract(), new Blizzard(), new Bulkup(), new Calmmind(), new Confide(), new Doubleteam(), new Dreameater(), new Embargo(), new Facade(), new Fling(), new Frostbreath(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Icebeam(), new Irontail(), new Lightscreen(), new Liquidation(), new Magiccoat(), new Magicroom(), new Painsplit(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Signalbeam(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Telekinesis(), new Torment(), new Toxic(), new Trickroom(), new Uproar(), new Venoshock(), new Waterfall(), new Waterpulse(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Icefang(), new Poisonfang(), new Rage(), new Waterpulse() };
		public override int Weight => 190;
		public override int ExpYield => 166;
		public override int CatchRate => 80;
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