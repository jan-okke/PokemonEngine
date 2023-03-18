using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Palpitoad : Pokemon
	{
		public override string Name => "Palpitoad";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(75, 65, 55, 65, 55, 69);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Echoedvoice(), new Growl(), new Acid(), new Supersonic() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Flail() },
			[30] = new List<Move>() { new Uproar() },
			[37] = new List<Move>() { new Aquaring() },
			[42] = new List<Move>() { new Hypervoice() },
			[48] = new List<Move>() { new Muddywater() },
			[54] = new List<Move>() { new Raindance() },
			[60] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bulldoze(), new Earthpower(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icywind(), new Muddywater(), new Mudshot(), new Powerwhip(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Substitute(), new Surf(), new Uproar(), new Venomdrench(), new Weatherball() };
		public override int Weight => 170;
		public override int ExpYield => 134;
		public override int CatchRate => 120;
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