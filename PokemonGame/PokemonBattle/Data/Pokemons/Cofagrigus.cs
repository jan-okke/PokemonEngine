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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Mummy() };
		public override Stats BaseStats => new Stats(58, 50, 145, 95, 105, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Shadowclaw() },
			[1] = new List<Move>() { new Moves.Shadowclaw(), new Moves.Scaryface(), new Moves.Astonish(), new Moves.Protect(), new Moves.Haze(), new Moves.Nightshade() },
			[12] = new List<Move>() { new Moves.Disable() },
			[16] = new List<Move>() { new Moves.Willowisp() },
			[20] = new List<Move>() { new Moves.Craftyshield() },
			[24] = new List<Move>() { new Moves.Hex() },
			[28] = new List<Move>() { new Moves.Meanlook() },
			[32] = new List<Move>() { new Moves.Grudge() },
			[38] = new List<Move>() { new Moves.Curse() },
			[44] = new List<Move>() { new Moves.Shadowball() },
			[50] = new List<Move>() { new Moves.Darkpulse() },
			[56] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
			[62] = new List<Move>() { new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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