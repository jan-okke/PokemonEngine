using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regice : Pokemon
	{
		public override string Name => "Regice";
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(80, 50, 100, 100, 200, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Chargebeam(), new Icywind() },
			[6] = new List<Move>() { new Bulldoze() },
			[12] = new List<Move>() { new Ancientpower() },
			[18] = new List<Move>() { new Stomp() },
			[24] = new List<Move>() { new Icebeam() },
			[30] = new List<Move>() { new Curse() },
			[36] = new List<Move>() { new Amnesia() },
			[42] = new List<Move>() { new Hammerarm() },
			[48] = new List<Move>() { new Blizzard() },
			[54] = new List<Move>() { new Superpower() },
			[60] = new List<Move>() { new Lockon() },
			[66] = new List<Move>() { new Zapcannon() },
			[72] = new List<Move>() { new Hyperbeam() },
			[78] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Chargebeam(), new Doubleteam(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Flashcannon(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Ironhead(), new Megakick(), new Megapunch(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Selfdestruct(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Superpower(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave() };
		public override int Weight => 1750;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}