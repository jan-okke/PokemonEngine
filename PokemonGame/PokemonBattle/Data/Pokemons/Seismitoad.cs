using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seismitoad : Pokemon
	{
		public override string Name => "Seismitoad";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Poisontouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(105, 95, 75, 74, 85, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Drainpunch() },
			[1] = new List<Move>() { new Drainpunch(), new Gastroacid(), new Echoedvoice(), new Growl(), new Acid(), new Supersonic() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Flail() },
			[30] = new List<Move>() { new Uproar() },
			[39] = new List<Move>() { new Aquaring() },
			[46] = new List<Move>() { new Hypervoice() },
			[54] = new List<Move>() { new Muddywater() },
			[62] = new List<Move>() { new Raindance() },
			[70] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Brickbreak(), new Bulldoze(), new Dig(), new Dive(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Icywind(), new Liquidation(), new Lowkick(), new Megakick(), new Megapunch(), new Muddywater(), new Mudshot(), new Payback(), new Poisonjab(), new Powerwhip(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scald(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Surf(), new Uproar(), new Venomdrench(), new Venoshock(), new Weatherball() };
		public override int Weight => 620;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}