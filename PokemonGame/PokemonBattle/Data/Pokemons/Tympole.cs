using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tympole : Pokemon
	{
		public override string Name => "Tympole";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(50, 50, 40, 64, 50, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Echoedvoice(), new Growl() },
			[4] = new List<Move>() { new Acid() },
			[8] = new List<Move>() { new Supersonic() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Flail() },
			[28] = new List<Move>() { new Uproar() },
			[32] = new List<Move>() { new Aquaring() },
			[36] = new List<Move>() { new Hypervoice() },
			[40] = new List<Move>() { new Muddywater() },
			[44] = new List<Move>() { new Raindance() },
			[48] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Earthpower(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icywind(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Uproar(), new Venomdrench(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Mist(), new Mudslap(), new Toxic(), new Waterpulse() };
		public override int Weight => 45;
		public override int ExpYield => 59;
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