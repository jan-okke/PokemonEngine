using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yamask : Pokemon
	{
		public override string Name => "Yamask";
		public override List<Ability> AvailableAbilities => new() {new Mummy() };
		public override Stats BaseStats => new Stats(38, 30, 85, 30, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Protect() },
			[4] = new List<Move>() { new Haze() },
			[8] = new List<Move>() { new Nightshade() },
			[12] = new List<Move>() { new Disable() },
			[16] = new List<Move>() { new Willowisp() },
			[20] = new List<Move>() { new Craftyshield() },
			[24] = new List<Move>() { new Hex() },
			[28] = new List<Move>() { new Meanlook() },
			[32] = new List<Move>() { new Grudge() },
			[36] = new List<Move>() { new Curse() },
			[40] = new List<Move>() { new Shadowball() },
			[44] = new List<Move>() { new Darkpulse() },
			[48] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[52] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Hex(), new Hiddenpower(), new Imprison(), new Irondefense(), new Nastyplot(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Thief(), new Toxicspikes(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Memento() };
		public override int Weight => 15;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}