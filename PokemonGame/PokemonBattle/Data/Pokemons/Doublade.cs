using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Doublade : Pokemon
	{
		public override string Name => "Doublade";
		public override List<Ability> AvailableAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(59, 110, 150, 45, 49, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Furycutter(), new Shadowsneak(), new Autotomize() },
			[12] = new List<Move>() { new Aerialace() },
			[16] = new List<Move>() { new Metalsound() },
			[20] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Nightslash() },
			[28] = new List<Move>() { new Retaliate() },
			[32] = new List<Move>() { new Irondefense() },
			[38] = new List<Move>() { new Ironhead() },
			[44] = new List<Move>() { new Powertrick() },
			[50] = new List<Move>() { new Swordsdance() },
			[56] = new List<Move>() { new Sacredsword() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Closecombat(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Protect(), new Psychocut(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Round(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarblade(), new Steelbeam(), new Substitute(), new Swordsdance() };
		public override int Weight => 45;
		public override int ExpYield => 157;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}