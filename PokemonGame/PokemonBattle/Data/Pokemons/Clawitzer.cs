using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clawitzer : Pokemon
	{
		public override string Name => "Clawitzer";
		public override List<Ability> AvailableAbilities => new() {new Megalauncher() };
		public override Stats BaseStats => new Stats(71, 73, 88, 59, 120, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Darkpulse(), new Dragonpulse(), new Healpulse(), new Splash(), new Watergun(), new Visegrip(), new Flail() },
			[15] = new List<Move>() { new Aquajet() },
			[20] = new List<Move>() { new Smackdown() },
			[25] = new List<Move>() { new Honeclaws() },
			[30] = new List<Move>() { new Waterpulse() },
			[35] = new List<Move>() { new Swordsdance() },
			[42] = new List<Move>() { new Aurasphere() },
			[49] = new List<Move>() { new Bounce() },
			[56] = new List<Move>() { new Muddywater() },
			[63] = new List<Move>() { new Crabhammer() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Bounce(), new Darkpulse(), new Dive(), new Dragonpulse(), new Endure(), new Facade(), new Flashcannon(), new Flipturn(), new Focusblast(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Liquidation(), new Muddywater(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Scald(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Swordsdance(), new Terrainpulse(), new Uturn(), new Venoshock(), new Waterfall() };
		public override int Weight => 353;
		public override int ExpYield => 100;
		public override int CatchRate => 55;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}