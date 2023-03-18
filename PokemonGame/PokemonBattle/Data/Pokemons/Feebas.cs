using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Feebas : Pokemon
	{
		public override string Name => "Feebas";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(20, 15, 20, 80, 10, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash() },
			[15] = new List<Move>() { new Tackle() },
			[25] = new List<Move>() { new Flail() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Dive(), new Doubleteam(), new Dragonpulse(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Lightscreen(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Confuseray(), new Dragonbreath(), new Haze(), new Hypnosis(), new Mirrorcoat(), new Mist(), new Tickle() };
		public override int Weight => 74;
		public override int ExpYield => 40;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}