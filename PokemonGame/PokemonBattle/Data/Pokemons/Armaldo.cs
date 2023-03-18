using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Armaldo : Pokemon
	{
		public override string Name => "Armaldo";
		public override List<Ability> AvailableAbilities => new() {new Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(75, 125, 100, 70, 80, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Harden(), new Watergun(), new Smackdown() },
			[12] = new List<Move>() { new Metalclaw() },
			[16] = new List<Move>() { new Ancientpower() },
			[20] = new List<Move>() { new Bugbite() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Crushclaw() },
			[36] = new List<Move>() { new Rockblast() },
			[43] = new List<Move>() { new Protect() },
			[48] = new List<Move>() { new Xscissor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bodyslam(), new Brickbreak(), new Brine(), new Brutalswing(), new Bulldoze(), new Crosspoison(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Irontail(), new Liquidation(), new Lowkick(), new Meteorbeam(), new Mudshot(), new Protect(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Waterpulse(), new Xscissor() };
		public override int Weight => 682;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}