using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cofagrigus : Pokemon
	{
		public override string Name => "Cofagrigus";
		public override List<Ability> AvailableAbilities => new() {new Mummy() };
		public override Stats BaseStats => new Stats(58, 50, 145, 30, 95, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Shadowclaw() },
			[1] = new List<Move>() { new Shadowclaw(), new Scaryface(), new Astonish(), new Protect(), new Haze(), new Nightshade() },
			[12] = new List<Move>() { new Disable() },
			[16] = new List<Move>() { new Willowisp() },
			[20] = new List<Move>() { new Craftyshield() },
			[24] = new List<Move>() { new Hex() },
			[28] = new List<Move>() { new Meanlook() },
			[32] = new List<Move>() { new Grudge() },
			[38] = new List<Move>() { new Curse() },
			[44] = new List<Move>() { new Shadowball() },
			[50] = new List<Move>() { new Darkpulse() },
			[56] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[62] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodypress(), new Calmmind(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irondefense(), new Nastyplot(), new Payback(), new Phantomforce(), new Poltergeist(), new Powerswap(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Revenge(), new Round(), new Safeguard(), new Scaryface(), new Shadowball(), new Shadowclaw(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Thief(), new Toxicspikes(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 765;
		public override int ExpYield => 169;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}