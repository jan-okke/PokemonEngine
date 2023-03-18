using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sharpedo : Pokemon
	{
		public override string Name => "Sharpedo";
		public override List<Ability> AvailableAbilities => new() {new Roughskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(70, 120, 40, 95, 40, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Nightslash(), new Aquajet(), new Leer(), new Poisonfang(), new Focusenergy() },
			[12] = new List<Move>() { new Scaryface() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Icefang() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Swagger() },
			[34] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Agility() },
			[46] = new List<Move>() { new Liquidation() },
			[52] = new List<Move>() { new Takedown() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Avalanche(), new Blizzard(), new Bounce(), new Brine(), new Bulldoze(), new Closecombat(), new Crunch(), new Darkpulse(), new Dive(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Flipturn(), new Focusenergy(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icywind(), new Liquidation(), new Payback(), new Poisonjab(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Scaleshot(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 888;
		public override int ExpYield => 161;
		public override int CatchRate => 60;
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