using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tentacool : Pokemon
	{
		public override string Name => "Tentacool";
		public override List<Ability> AvailableAbilities => new() {new Clearbody(), new Liquidooze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(40, 40, 35, 50, 100, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Watergun() },
			[4] = new List<Move>() { new Acid() },
			[8] = new List<Move>() { new Wrap() },
			[12] = new List<Move>() { new Supersonic() },
			[16] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Bubblebeam() },
			[28] = new List<Move>() { new Hex() },
			[32] = new List<Move>() { new Acidarmor() },
			[36] = new List<Move>() { new Poisonjab() },
			[40] = new List<Move>() { new Surf() },
			[44] = new List<Move>() { new Sludgewave() },
			[48] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Brutalswing(), new Crosspoison(), new Cut(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Gigadrain(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Muddywater(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Toxicspikes(), new Venoshock(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Aquaring(), new Aurorabeam(), new Confuseray(), new Haze(), new Knockoff(), new Mirrorcoat(), new Muddywater(), new Rapidspin(), new Tickle() };
		public override int Weight => 455;
		public override int ExpYield => 67;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}