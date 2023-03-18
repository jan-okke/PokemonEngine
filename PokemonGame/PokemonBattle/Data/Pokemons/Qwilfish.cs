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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Intimidate() };
		public override Stats BaseStats => new Stats(65, 95, 85, 55, 55, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Harden() },
			[8] = new List<Move>() { new Moves.Watergun() },
			[12] = new List<Move>() { new Moves.Fellstinger() },
			[16] = new List<Move>() { new Moves.Minimize() },
			[20] = new List<Move>() { new Moves.Spikes() },
			[24] = new List<Move>() { new Moves.Brine() },
			[28] = new List<Move>() { new Moves.Revenge() },
			[32] = new List<Move>() { new Moves.Pinmissile() },
			[36] = new List<Move>() { new Moves.Toxicspikes() },
			[40] = new List<Move>() { new Moves.Poisonjab() },
			[44] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup() },
			[48] = new List<Move>() { new Moves.Takedown() },
			[52] = new List<Move>() { new Moves.Toxic() },
			[56] = new List<Move>() { new Moves.Aquatail() },
			[60] = new List<Move>() { new Moves.Acupressure() },
			[66] = new List<Move>() { new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Spikes(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Aquajet(), new Moves.Astonish(), new Moves.Bubblebeam(), new Moves.Flail(), new Moves.Haze(), new Moves.Supersonic() };
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