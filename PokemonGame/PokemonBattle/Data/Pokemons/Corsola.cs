using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Corsola : Pokemon
	{
		public override string Name => "Corsola";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(65, 55, 95, 35, 65, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[5] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Aquaring() },
			[15] = new List<Move>() { new Endure() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Flail() },
			[35] = new List<Move>() { new Lifedew() },
			[40] = new List<Move>() { new Powergem() },
			[45] = new List<Move>() { new Earthpower() },
			[50] = new List<Move>() { new Recover() },
			[55] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Calmmind(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Lightscreen(), new Liquidation(), new Meteorbeam(), new Powergem(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Screech(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Throatchop(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Aquaring(), new Confuseray(), new Curse(), new Headsmash(), new Iciclespear(), new Ingrain(), new Liquidation(), new Mist(), new Naturepower(), new Screech() };
		public override int Weight => 50;
		public override int ExpYield => 144;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}