using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cubone : Pokemon
	{
		public override string Name => "Cubone";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Battlearmor() };
		public override Stats BaseStats => new Stats(50, 50, 95, 35, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Growl() },
			[4] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Falseswipe() },
			[12] = new List<Move>() { new Headbutt() },
			[16] = new List<Move>() { new Retaliate() },
			[20] = new List<Move>() { new Fling() },
			[24] = new List<Move>() { new Stompingtantrum() },
			[29] = new List<Move>() { new Bonerush() },
			[32] = new List<Move>() { new Focusenergy() },
			[36] = new List<Move>() { new Endeavor() },
			[40] = new List<Move>() { new Bonemerang() },
			[44] = new List<Move>() { new Thrash() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusenergy(), new Focuspunch(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scorchingsands(), new Screech(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Thunderpunch(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Bellydrum(), new Curse(), new Detect(), new Doublekick(), new Ironhead(), new Leer(), new Perishsong(), new Screech(), new Skullbash() };
		public override int Weight => 65;
		public override int ExpYield => 64;
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