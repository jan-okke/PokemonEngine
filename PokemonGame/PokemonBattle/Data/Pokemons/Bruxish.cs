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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Dazzling(), new Abilities.Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Wonderskin() };
		public override Stats BaseStats => new Stats(68, 105, 70, 70, 70, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Watergun() },
			[4] = new List<Move>() { new Moves.Astonish() },
			[9] = new List<Move>() { new Moves.Confusion() },
			[12] = new List<Move>() { new Moves.Bite() },
			[17] = new List<Move>() { new Moves.Aquajet() },
			[20] = new List<Move>() { new Moves.Disable() },
			[25] = new List<Move>() { new Moves.Psywave() },
			[28] = new List<Move>() { new Moves.Crunch() },
			[33] = new List<Move>() { new Moves.Aquatail() },
			[36] = new List<Move>() { new Moves.Screech() },
			[41] = new List<Move>() { new Moves.Psychicfangs() },
			[44] = new List<Move>() { new Moves.Synchronoise() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Allyswitch(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bulkup(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Facade(), new Moves.Fling(), new Moves.Frostbreath(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Torment(), new Moves.Toxic(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Icefang(), new Moves.Poisonfang(), new Moves.Rage(), new Moves.Waterpulse() };
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