using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tentacruel : Pokemon
	{
		public override string Name => "Tentacruel";
		public override List<Ability> AvailableAbilities => new() {new Clearbody(), new Liquidooze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(80, 70, 65, 80, 120, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Reflecttype(), new Poisonsting(), new Watergun(), new Acid(), new Wrap() },
			[12] = new List<Move>() { new Supersonic() },
			[16] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Bubblebeam() },
			[28] = new List<Move>() { new Hex() },
			[34] = new List<Move>() { new Acidarmor() },
			[40] = new List<Move>() { new Poisonjab() },
			[46] = new List<Move>() { new Surf() },
			[52] = new List<Move>() { new Sludgewave() },
			[58] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Brutalswing(), new Corrosivegas(), new Crosspoison(), new Cut(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Gigadrain(), new Gigaimpact(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Muddywater(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 550;
		public override int ExpYield => 180;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}