using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Liepard : Pokemon
	{
		public override string Name => "Liepard";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(64, 88, 50, 88, 50, 106);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl(), new Sandattack(), new Fakeout() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Torment() },
			[23] = new List<Move>() { new Assurance() },
			[28] = new List<Move>() { new Honeclaws() },
			[34] = new List<Move>() { new Suckerpunch() },
			[40] = new List<Move>() { new Nastyplot() },
			[46] = new List<Move>() { new Nightslash() },
			[52] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Burningjealousy(), new Charm(), new Darkpulse(), new Encore(), new Endure(), new Facade(), new Faketears(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Psychocut(), new Raindance(), new Rest(), new Round(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Thunderwave(), new Trick(), new Uturn() };
		public override int Weight => 375;
		public override int ExpYield => 156;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}