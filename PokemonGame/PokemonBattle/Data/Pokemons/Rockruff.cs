using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rockruff : Pokemon
	{
		public override string Name => "Rockruff";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Vitalspirit() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(45, 65, 40, 60, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Sandattack() },
			[8] = new List<Move>() { new Doubleteam() },
			[12] = new List<Move>() { new Rockthrow() },
			[16] = new List<Move>() { new Howl() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Rocktomb() },
			[28] = new List<Move>() { new Roar() },
			[32] = new List<Move>() { new Rockslide() },
			[36] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Scaryface() },
			[44] = new List<Move>() { new Stealthrock() },
			[48] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Crunch(), new Earthpower(), new Endure(), new Facade(), new Firefang(), new Hiddenpower(), new Hypervoice(), new Irondefense(), new Ironhead(), new Irontail(), new Playrough(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Swordsdance(), new Taunt(), new Thunderfang(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Endeavor(), new Lastresort(), new Thrash() };
		public override int Weight => 92;
		public override int ExpYield => 56;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}