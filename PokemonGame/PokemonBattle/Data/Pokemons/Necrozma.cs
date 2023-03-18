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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Prismarmor() };
		public override Stats BaseStats => new Stats(97, 107, 101, 127, 89, 79);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Moonlight(), new Moves.Morningsun(), new Moves.Chargebeam(), new Moves.Gravity(), new Moves.Metalclaw(), new Moves.Confusion() },
			[8] = new List<Move>() { new Moves.Stealthrock() },
			[16] = new List<Move>() { new Moves.Slash() },
			[24] = new List<Move>() { new Moves.Nightslash() },
			[32] = new List<Move>() { new Moves.Psychocut() },
			[40] = new List<Move>() { new Moves.Storedpower() },
			[48] = new List<Move>() { new Moves.Rockblast() },
			[56] = new List<Move>() { new Moves.Irondefense() },
			[64] = new List<Move>() { new Moves.Powergem() },
			[72] = new List<Move>() { new Moves.Photongeyser() },
			[80] = new List<Move>() { new Moves.Autotomize() },
			[88] = new List<Move>() { new Moves.Prismaticlaser() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Darkpulse(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicfangs(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Xscissor() };
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