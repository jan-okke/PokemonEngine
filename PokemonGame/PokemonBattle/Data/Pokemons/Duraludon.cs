using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Duraludon : Pokemon
	{
		public override string Name => "Duraludon";
		public override List<Ability> AvailableAbilities => new() {new Lightmetal(), new Heavymetal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stalwart() };
		public override Stats BaseStats => new Stats(70, 95, 115, 85, 120, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Metalclaw(), new Leer() },
			[6] = new List<Move>() { new Rocksmash() },
			[12] = new List<Move>() { new Honeclaws() },
			[18] = new List<Move>() { new Metalsound() },
			[24] = new List<Move>() { new Breakingswipe() },
			[30] = new List<Move>() { new Dragontail() },
			[36] = new List<Move>() { new Irondefense() },
			[42] = new List<Move>() { new Laserfocus() },
			[48] = new List<Move>() { new Dragonclaw() },
			[54] = new List<Move>() { new Flashcannon() },
			[60] = new List<Move>() { new Metalburst() },
			[66] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Darkpulse(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Endure(), new Facade(), new Flashcannon(), new Foulplay(), new Gigaimpact(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lightscreen(), new Outrage(), new Protect(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Swordsdance(), new Thunder(), new Thunderbolt(), new Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Mirrorcoat(), new Nightslash(), new Slash() };
		public override int Weight => 400;
		public override int ExpYield => 187;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}