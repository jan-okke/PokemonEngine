using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aggron : Pokemon
	{
		public override string Name => "Aggron";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(70, 110, 180, 50, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden(), new Metalclaw(), new Rocktomb() },
			[12] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Rockslide() },
			[28] = new List<Move>() { new Ironhead() },
			[35] = new List<Move>() { new Metalsound() },
			[40] = new List<Move>() { new Takedown() },
			[48] = new List<Move>() { new Autotomize() },
			[56] = new List<Move>() { new Irontail() },
			[64] = new List<Move>() { new Irondefense() },
			[72] = new List<Move>() { new Heavyslam() },
			[80] = new List<Move>() { new Doubleedge() },
			[88] = new List<Move>() { new Metalburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flashcannon(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Meteorbeam(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Screech(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 3600;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
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