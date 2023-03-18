using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Honedge : Pokemon
	{
		public override string Name => "Honedge";
		public override List<Ability> AvailableAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(45, 80, 100, 28, 35, 37);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Furycutter() },
			[4] = new List<Move>() { new Shadowsneak() },
			[8] = new List<Move>() { new Autotomize() },
			[12] = new List<Move>() { new Aerialace() },
			[16] = new List<Move>() { new Metalsound() },
			[20] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Nightslash() },
			[28] = new List<Move>() { new Retaliate() },
			[32] = new List<Move>() { new Irondefense() },
			[36] = new List<Move>() { new Ironhead() },
			[40] = new List<Move>() { new Powertrick() },
			[44] = new List<Move>() { new Swordsdance() },
			[48] = new List<Move>() { new Sacredsword() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Closecombat(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Protect(), new Psychocut(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Round(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarblade(), new Steelbeam(), new Substitute(), new Swordsdance() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Destinybond(), new Wideguard() };
		public override int Weight => 20;
		public override int ExpYield => 65;
		public override int CatchRate => 180;
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