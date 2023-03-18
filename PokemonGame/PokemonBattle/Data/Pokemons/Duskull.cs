using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Duskull : Pokemon
	{
		public override string Name => "Duskull";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(20, 40, 90, 30, 90, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Leer() },
			[4] = new List<Move>() { new Disable() },
			[8] = new List<Move>() { new Shadowsneak() },
			[12] = new List<Move>() { new Confuseray() },
			[16] = new List<Move>() { new Nightshade() },
			[20] = new List<Move>() { new Payback() },
			[24] = new List<Move>() { new Willowisp() },
			[28] = new List<Move>() { new Meanlook() },
			[32] = new List<Move>() { new Hex() },
			[36] = new List<Move>() { new Curse() },
			[40] = new List<Move>() { new Shadowball() },
			[44] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Blizzard(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Fling(), new Futuresight(), new Helpinghand(), new Hex(), new Hiddenpower(), new Icebeam(), new Icywind(), new Imprison(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Revenge(), new Round(), new Shadowball(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Destinybond(), new Grudge(), new Haze(), new Imprison(), new Memento(), new Painsplit() };
		public override int Weight => 150;
		public override int ExpYield => 59;
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