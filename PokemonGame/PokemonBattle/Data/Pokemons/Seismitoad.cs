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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Poisontouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
		public override Stats BaseStats => new Stats(105, 95, 75, 85, 75, 74);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Drainpunch() },
			[1] = new List<Move>() { new Moves.Drainpunch(), new Moves.Gastroacid(), new Moves.Echoedvoice(), new Moves.Growl(), new Moves.Acid(), new Moves.Supersonic() },
			[12] = new List<Move>() { new Moves.Mudshot() },
			[16] = new List<Move>() { new Moves.Round() },
			[20] = new List<Move>() { new Moves.Bubblebeam() },
			[24] = new List<Move>() { new Moves.Flail() },
			[30] = new List<Move>() { new Moves.Uproar() },
			[39] = new List<Move>() { new Moves.Aquaring() },
			[46] = new List<Move>() { new Moves.Hypervoice() },
			[54] = new List<Move>() { new Moves.Muddywater() },
			[62] = new List<Move>() { new Moves.Raindance() },
			[70] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Drainpunch(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Surf(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Weatherball() };
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