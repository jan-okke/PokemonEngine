using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Qwilfish : Pokemon
	{
		public override string Name => "Qwilfish";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(65, 95, 85, 55, 55, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Tackle() },
			[4] = new List<Move>() { new Harden() },
			[8] = new List<Move>() { new Watergun() },
			[12] = new List<Move>() { new Fellstinger() },
			[16] = new List<Move>() { new Minimize() },
			[20] = new List<Move>() { new Spikes() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Revenge() },
			[32] = new List<Move>() { new Pinmissile() },
			[36] = new List<Move>() { new Toxicspikes() },
			[40] = new List<Move>() { new Poisonjab() },
			[44] = new List<Move>() { new Stockpile(), new Spitup() },
			[48] = new List<Move>() { new Takedown() },
			[52] = new List<Move>() { new Toxic() },
			[56] = new List<Move>() { new Aquatail() },
			[60] = new List<Move>() { new Acupressure() },
			[66] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Dive(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Gyroball(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Liquidation(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Revenge(), new Reversal(), new Round(), new Scald(), new Scaleshot(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Spikes(), new Steelroller(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Throatchop(), new Thunderwave(), new Toxic(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Aquajet(), new Astonish(), new Bubblebeam(), new Flail(), new Haze(), new Supersonic() };
		public override int Weight => 39;
		public override int ExpYield => 88;
		public override int CatchRate => 45;
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