using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nosepass : Pokemon
	{
		public override string Name => "Nosepass";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Magnetpull() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(30, 45, 135, 45, 90, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[4] = new List<Move>() { new Harden() },
			[7] = new List<Move>() { new Block() },
			[10] = new List<Move>() { new Rockthrow() },
			[13] = new List<Move>() { new Thunderwave() },
			[16] = new List<Move>() { new Rest() },
			[19] = new List<Move>() { new Spark() },
			[22] = new List<Move>() { new Rockslide() },
			[25] = new List<Move>() { new Powergem() },
			[28] = new List<Move>() { new Rockblast() },
			[31] = new List<Move>() { new Discharge() },
			[34] = new List<Move>() { new Sandstorm() },
			[37] = new List<Move>() { new Earthpower() },
			[40] = new List<Move>() { new Stoneedge() },
			[43] = new List<Move>() { new Lockon(), new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Bulldoze(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Firepunch(), new Frustration(), new Gravity(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Magiccoat(), new Magnetrise(), new Painsplit(), new Protect(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Voltswitch() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Doubleedge(), new Rollout(), new Wideguard() };
		public override int Weight => 970;
		public override int ExpYield => 75;
		public override int CatchRate => 255;
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