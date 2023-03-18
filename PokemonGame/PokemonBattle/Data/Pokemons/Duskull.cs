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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(20, 40, 90, 30, 90, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Astonish(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Disable() },
			[8] = new List<Move>() { new Moves.Shadowsneak() },
			[12] = new List<Move>() { new Moves.Confuseray() },
			[16] = new List<Move>() { new Moves.Nightshade() },
			[20] = new List<Move>() { new Moves.Payback() },
			[24] = new List<Move>() { new Moves.Willowisp() },
			[28] = new List<Move>() { new Moves.Meanlook() },
			[32] = new List<Move>() { new Moves.Hex() },
			[36] = new List<Move>() { new Moves.Curse() },
			[40] = new List<Move>() { new Moves.Shadowball() },
			[44] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Destinybond(), new Moves.Grudge(), new Moves.Haze(), new Moves.Imprison(), new Moves.Memento(), new Moves.Painsplit() };
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