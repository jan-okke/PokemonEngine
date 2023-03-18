using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shieldon : Pokemon
	{
		public override string Name => "Shieldon";
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Soundproof() };
		public override Stats BaseStats => new Stats(30, 42, 118, 30, 42, 88);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Protect() },
			[6] = new List<Move>() { new Taunt() },
			[10] = new List<Move>() { new Metalsound() },
			[15] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Swagger() },
			[28] = new List<Move>() { new Ancientpower() },
			[33] = new List<Move>() { new Endure() },
			[37] = new List<Move>() { new Metalburst() },
			[42] = new List<Move>() { new Ironhead() },
			[46] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flashcannon(), new Frustration(), new Hiddenpower(), new Icebeam(), new Irondefense(), new Ironhead(), new Irontail(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Torment() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Counter(), new Curse(), new Doubleedge(), new Fissure(), new Focusenergy(), new Guardsplit(), new Headbutt(), new Rockblast(), new Scaryface(), new Screech(), new Wideguard() };
		public override int Weight => 570;
		public override int ExpYield => 70;
		public override int CatchRate => 45;
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