using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Thievul : Pokemon
	{
		public override string Name => "Thievul";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stakeout() };
		public override Stats BaseStats => new Stats(70, 58, 58, 90, 87, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thief() },
			[1] = new List<Move>() { new Thief(), new Quickattack(), new Tailwhip(), new Beatup(), new Honeclaws() },
			[12] = new List<Move>() { new Snarl() },
			[16] = new List<Move>() { new Assurance() },
			[22] = new List<Move>() { new Nastyplot() },
			[28] = new List<Move>() { new Suckerpunch() },
			[34] = new List<Move>() { new Nightslash() },
			[40] = new List<Move>() { new Tailslap() },
			[46] = new List<Move>() { new Foulplay() },
			[52] = new List<Move>() { new Partingshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Attract(), new Batonpass(), new Beatup(), new Burningjealousy(), new Crunch(), new Darkpulse(), new Dig(), new Endure(), new Facade(), new Faketears(), new Firefang(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Icefang(), new Lashout(), new Mudshot(), new Nastyplot(), new Playrough(), new Protect(), new Psychic(), new Rest(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Swift(), new Tailslap(), new Taunt(), new Thief(), new Thunderfang(), new Uturn() };
		public override int Weight => 199;
		public override int ExpYield => 159;
		public override int CatchRate => 127;
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