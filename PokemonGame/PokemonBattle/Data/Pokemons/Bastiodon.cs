using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bastiodon : Pokemon
	{
		public override string Name => "Bastiodon";
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Soundproof() };
		public override Stats BaseStats => new Stats(60, 52, 168, 30, 47, 138);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Block() },
			[1] = new List<Move>() { new Block(), new Tackle(), new Protect(), new Taunt(), new Metalsound() },
			[6] = new List<Move>() { new Taunt() },
			[10] = new List<Move>() { new Metalsound() },
			[15] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Swagger() },
			[28] = new List<Move>() { new Ancientpower() },
			[36] = new List<Move>() { new Endure() },
			[43] = new List<Move>() { new Metalburst() },
			[51] = new List<Move>() { new Ironhead() },
			[58] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Block(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flashcannon(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Irondefense(), new Ironhead(), new Irontail(), new Magiccoat(), new Magnetrise(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Torment() };
		public override int Weight => 1495;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
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