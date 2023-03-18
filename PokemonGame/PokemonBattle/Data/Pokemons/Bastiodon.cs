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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Soundproof() };
		public override Stats BaseStats => new Stats(60, 52, 168, 47, 138, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Block() },
			[1] = new List<Move>() { new Moves.Block(), new Moves.Tackle(), new Moves.Protect(), new Moves.Taunt(), new Moves.Metalsound() },
			[6] = new List<Move>() { new Moves.Taunt() },
			[10] = new List<Move>() { new Moves.Metalsound() },
			[15] = new List<Move>() { new Moves.Takedown() },
			[19] = new List<Move>() { new Moves.Irondefense() },
			[24] = new List<Move>() { new Moves.Swagger() },
			[28] = new List<Move>() { new Moves.Ancientpower() },
			[36] = new List<Move>() { new Moves.Endure() },
			[43] = new List<Move>() { new Moves.Metalburst() },
			[51] = new List<Move>() { new Moves.Ironhead() },
			[58] = new List<Move>() { new Moves.Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Block(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Magiccoat(), new Moves.Magnetrise(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Torment() };
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