using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marowak : Pokemon
	{
		public override string Name => "Marowak";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Battlearmor() };
		public override Stats BaseStats => new Stats(60, 80, 110, 45, 50, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Growl(), new Tailwhip(), new Falseswipe() },
			[12] = new List<Move>() { new Headbutt() },
			[16] = new List<Move>() { new Retaliate() },
			[20] = new List<Move>() { new Fling() },
			[24] = new List<Move>() { new Stompingtantrum() },
			[31] = new List<Move>() { new Bonerush() },
			[36] = new List<Move>() { new Focusenergy() },
			[42] = new List<Move>() { new Endeavor() },
			[48] = new List<Move>() { new Bonemerang() },
			[54] = new List<Move>() { new Thrash() },
			[60] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Outrage(), new Protect(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scorchingsands(), new Screech(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Throatchop(), new Thunderpunch(), new Uproar() };
		public override int Weight => 450;
		public override int ExpYield => 149;
		public override int CatchRate => 75;
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