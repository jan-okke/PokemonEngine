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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
		public override Stats BaseStats => new Stats(64, 88, 50, 88, 50, 106);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl(), new Moves.Sandattack(), new Moves.Fakeout() },
			[12] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Torment() },
			[23] = new List<Move>() { new Moves.Assurance() },
			[28] = new List<Move>() { new Moves.Honeclaws() },
			[34] = new List<Move>() { new Moves.Suckerpunch() },
			[40] = new List<Move>() { new Moves.Nastyplot() },
			[46] = new List<Move>() { new Moves.Nightslash() },
			[52] = new List<Move>() { new Moves.Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Burningjealousy(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uturn() };
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