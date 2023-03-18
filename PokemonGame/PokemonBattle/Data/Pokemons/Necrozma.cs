using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Necrozma : Pokemon
	{
		public override string Name => "Necrozma";
		public override List<Ability> AvailableAbilities => new() {new Prismarmor() };
		public override Stats BaseStats => new Stats(97, 107, 101, 127, 89, 79);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moonlight(), new Morningsun(), new Chargebeam(), new Gravity(), new Metalclaw(), new Confusion() },
			[8] = new List<Move>() { new Stealthrock() },
			[16] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Nightslash() },
			[32] = new List<Move>() { new Psychocut() },
			[40] = new List<Move>() { new Storedpower() },
			[48] = new List<Move>() { new Rockblast() },
			[56] = new List<Move>() { new Irondefense() },
			[64] = new List<Move>() { new Powergem() },
			[72] = new List<Move>() { new Photongeyser() },
			[80] = new List<Move>() { new Autotomize() },
			[88] = new List<Move>() { new Prismaticlaser() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Calmmind(), new Cosmicpower(), new Darkpulse(), new Dragondance(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Expandingforce(), new Facade(), new Flashcannon(), new Fling(), new Futuresight(), new Gigaimpact(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Irondefense(), new Ironhead(), new Lightscreen(), new Meteorbeam(), new Outrage(), new Powergem(), new Protect(), new Psychic(), new Psychicfangs(), new Psychocut(), new Psyshock(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Stealthrock(), new Stoneedge(), new Storedpower(), new Substitute(), new Swordsdance(), new Thief(), new Thunderwave(), new Trickroom(), new Xscissor() };
		public override int Weight => 2300;
		public override int ExpYield => 300;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}