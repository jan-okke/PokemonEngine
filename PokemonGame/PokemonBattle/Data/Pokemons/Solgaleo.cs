using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Solgaleo : Pokemon
	{
		public override string Name => "Solgaleo";
		public override List<Ability> AvailableAbilities => new() {new Fullmetalbody() };
		public override Stats BaseStats => new Stats(137, 137, 107, 113, 89, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Sunsteelstrike() },
			[1] = new List<Move>() { new Sunsteelstrike(), new Cosmicpower(), new Teleport(), new Metalclaw(), new Nobleroar() },
			[7] = new List<Move>() { new Ironhead() },
			[14] = new List<Move>() { new Metalsound() },
			[21] = new List<Move>() { new Zenheadbutt() },
			[28] = new List<Move>() { new Flashcannon() },
			[35] = new List<Move>() { new Morningsun() },
			[42] = new List<Move>() { new Crunch() },
			[49] = new List<Move>() { new Metalburst() },
			[56] = new List<Move>() { new Wildcharge() },
			[63] = new List<Move>() { new Solarbeam() },
			[70] = new List<Move>() { new Flareblitz() },
			[77] = new List<Move>() { new Wideguard() },
			[84] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Bulldoze(), new Calmmind(), new Closecombat(), new Cosmicpower(), new Crunch(), new Earthquake(), new Endure(), new Expandingforce(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Flashcannon(), new Focusblast(), new Futuresight(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Ironhead(), new Irontail(), new Lightscreen(), new Meteorbeam(), new Mysticalfire(), new Outrage(), new Protect(), new Psychic(), new Psychicfangs(), new Psyshock(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Steelbeam(), new Steelroller(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trickroom(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override int Weight => 2300;
		public override int ExpYield => 340;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}