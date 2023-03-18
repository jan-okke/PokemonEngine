using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Carvanha : Pokemon
	{
		public override string Name => "Carvanha";
		public override List<Ability> AvailableAbilities => new() {new Roughskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(45, 90, 20, 65, 20, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Aquajet(), new Leer() },
			[4] = new List<Move>() { new Poisonfang() },
			[8] = new List<Move>() { new Focusenergy() },
			[12] = new List<Move>() { new Scaryface() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Icefang() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Swagger() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Agility() },
			[40] = new List<Move>() { new Liquidation() },
			[44] = new List<Move>() { new Takedown() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Crunch(), new Darkpulse(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Flipturn(), new Focusenergy(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icefang(), new Icywind(), new Liquidation(), new Payback(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Scald(), new Scaleshot(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Destinybond(), new Doubleedge(), new Hydropump(), new Swift(), new Thrash() };
		public override int Weight => 208;
		public override int ExpYield => 61;
		public override int CatchRate => 225;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}