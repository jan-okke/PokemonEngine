using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cursola : Pokemon
	{
		public override string Name => "Cursola";
		public override List<Ability> AvailableAbilities => new() {new Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Perishbody() };
		public override Stats BaseStats => new Stats(60, 95, 50, 145, 130, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Perishsong(), new Tackle(), new Harden(), new Astonish(), new Disable() },
			[15] = new List<Move>() { new Spite() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Hex() },
			[30] = new List<Move>() { new Curse() },
			[35] = new List<Move>() { new Strengthsap() },
			[40] = new List<Move>() { new Powergem() },
			[45] = new List<Move>() { new Nightshade() },
			[50] = new List<Move>() { new Grudge() },
			[55] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Burningjealousy(), new Calmmind(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigadrain(), new Gigaimpact(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Leechlife(), new Lightscreen(), new Liquidation(), new Meteorbeam(), new Pinmissile(), new Poltergeist(), new Powergem(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Revenge(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Screech(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Surf(), new Throatchop(), new Whirlpool(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Confuseray(), new Destinybond(), new Haze(), new Headsmash(), new Naturepower(), new Waterpulse() };
		public override int Weight => 4;
		public override int ExpYield => 179;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}