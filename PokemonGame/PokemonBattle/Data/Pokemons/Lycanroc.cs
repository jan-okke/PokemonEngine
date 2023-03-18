using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lycanroc : Pokemon
	{
		public override string Name => "Lycanroc";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Sandrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(75, 115, 65, 55, 65, 112);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Suckerpunch() },
			[1] = new List<Move>() { new Suckerpunch(), new Accelerock(), new Quickguard(), new Quickattack(), new Tackle(), new Leer(), new Sandattack(), new Doubleteam() },
			[12] = new List<Move>() { new Rockthrow() },
			[16] = new List<Move>() { new Howl() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Rocktomb() },
			[30] = new List<Move>() { new Roar() },
			[36] = new List<Move>() { new Rockslide() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Scaryface() },
			[54] = new List<Move>() { new Stealthrock() },
			[60] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Brickbreak(), new Bulkup(), new Closecombat(), new Crunch(), new Drillrun(), new Earthpower(), new Endure(), new Facade(), new Firefang(), new Gigaimpact(), new Hiddenpower(), new Hypervoice(), new Irondefense(), new Ironhead(), new Irontail(), new Playrough(), new Protect(), new Psychicfangs(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Swift(), new Swordsdance(), new Tailslap(), new Taunt(), new Thunderfang(), new Zenheadbutt() };
		public override int Weight => 250;
		public override int ExpYield => 170;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}