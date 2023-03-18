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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Noguard() };
		public override Stats BaseStats => new Stats(45, 80, 100, 35, 37, 28);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Furycutter() },
			[4] = new List<Move>() { new Moves.Shadowsneak() },
			[8] = new List<Move>() { new Moves.Autotomize() },
			[12] = new List<Move>() { new Moves.Aerialace() },
			[16] = new List<Move>() { new Moves.Metalsound() },
			[20] = new List<Move>() { new Moves.Slash() },
			[24] = new List<Move>() { new Moves.Nightslash() },
			[28] = new List<Move>() { new Moves.Retaliate() },
			[32] = new List<Move>() { new Moves.Irondefense() },
			[36] = new List<Move>() { new Moves.Ironhead() },
			[40] = new List<Move>() { new Moves.Powertrick() },
			[44] = new List<Move>() { new Moves.Swordsdance() },
			[48] = new List<Move>() { new Moves.Sacredsword() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swordsdance() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Destinybond(), new Moves.Wideguard() };
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