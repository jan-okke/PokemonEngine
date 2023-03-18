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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Magnetpull() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
		public override Stats BaseStats => new Stats(30, 45, 135, 45, 90, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Harden() },
			[7] = new List<Move>() { new Moves.Block() },
			[10] = new List<Move>() { new Moves.Rockthrow() },
			[13] = new List<Move>() { new Moves.Thunderwave() },
			[16] = new List<Move>() { new Moves.Rest() },
			[19] = new List<Move>() { new Moves.Spark() },
			[22] = new List<Move>() { new Moves.Rockslide() },
			[25] = new List<Move>() { new Moves.Powergem() },
			[28] = new List<Move>() { new Moves.Rockblast() },
			[31] = new List<Move>() { new Moves.Discharge() },
			[34] = new List<Move>() { new Moves.Sandstorm() },
			[37] = new List<Move>() { new Moves.Earthpower() },
			[40] = new List<Move>() { new Moves.Stoneedge() },
			[43] = new List<Move>() { new Moves.Lockon(), new Moves.Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Frustration(), new Moves.Gravity(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Magiccoat(), new Moves.Magnetrise(), new Moves.Painsplit(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Voltswitch() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Doubleedge(), new Moves.Rollout(), new Moves.Wideguard() };
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