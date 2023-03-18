using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Purrloin : Pokemon
	{
		public override string Name => "Purrloin";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(41, 50, 37, 66, 50, 37);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl() },
			[4] = new List<Move>() { new Sandattack() },
			[5] = new List<Move>() { new Fakeout() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Torment() },
			[21] = new List<Move>() { new Assurance() },
			[24] = new List<Move>() { new Honeclaws() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Nastyplot() },
			[36] = new List<Move>() { new Nightslash() },
			[40] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Charm(), new Darkpulse(), new Encore(), new Endure(), new Facade(), new Faketears(), new Foulplay(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Round(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Thunderwave(), new Trick(), new Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Copycat(), new Covet(), new Doubleteam(), new Quickattack(), new Slash(), new Yawn() };
		public override int Weight => 101;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}