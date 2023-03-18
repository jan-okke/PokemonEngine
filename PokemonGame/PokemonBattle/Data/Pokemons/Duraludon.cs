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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Lightmetal(), new Abilities.Heavymetal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stalwart() };
		public override Stats BaseStats => new Stats(70, 95, 115, 120, 50, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Metalclaw(), new Moves.Leer() },
			[6] = new List<Move>() { new Moves.Rocksmash() },
			[12] = new List<Move>() { new Moves.Honeclaws() },
			[18] = new List<Move>() { new Moves.Metalsound() },
			[24] = new List<Move>() { new Moves.Breakingswipe() },
			[30] = new List<Move>() { new Moves.Dragontail() },
			[36] = new List<Move>() { new Moves.Irondefense() },
			[42] = new List<Move>() { new Moves.Laserfocus() },
			[48] = new List<Move>() { new Moves.Dragonclaw() },
			[54] = new List<Move>() { new Moves.Flashcannon() },
			[60] = new List<Move>() { new Moves.Metalburst() },
			[66] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Mirrorcoat(), new Moves.Nightslash(), new Moves.Slash() };
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