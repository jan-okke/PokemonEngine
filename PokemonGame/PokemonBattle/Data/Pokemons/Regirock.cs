using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regirock : Pokemon
	{
		public override string Name => "Regirock";
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(80, 100, 200, 50, 50, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Chargebeam(), new Rockthrow() },
			[6] = new List<Move>() { new Bulldoze() },
			[12] = new List<Move>() { new Ancientpower() },
			[18] = new List<Move>() { new Stomp() },
			[24] = new List<Move>() { new Rockslide() },
			[30] = new List<Move>() { new Curse() },
			[36] = new List<Move>() { new Irondefense() },
			[42] = new List<Move>() { new Hammerarm() },
			[48] = new List<Move>() { new Stoneedge() },
			[54] = new List<Move>() { new Superpower() },
			[60] = new List<Move>() { new Lockon() },
			[66] = new List<Move>() { new Zapcannon() },
			[72] = new List<Move>() { new Hyperbeam() },
			[78] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Chargebeam(), new Dig(), new Doubleteam(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Firepunch(), new Flashcannon(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irondefense(), new Ironhead(), new Megakick(), new Megapunch(), new Meteorbeam(), new Protect(), new Psychup(), new Rest(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Shockwave(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave() };
		public override int Weight => 2300;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}