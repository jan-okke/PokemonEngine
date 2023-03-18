using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rookidee : Pokemon
	{
		public override string Name => "Rookidee";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bigpecks() };
		public override Stats BaseStats => new Stats(38, 47, 35, 33, 35, 57);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Powertrip() },
			[8] = new List<Move>() { new Moves.Honeclaws() },
			[12] = new List<Move>() { new Moves.Furyattack() },
			[16] = new List<Move>() { new Moves.Pluck() },
			[20] = new List<Move>() { new Moves.Taunt() },
			[24] = new List<Move>() { new Moves.Scaryface() },
			[28] = new List<Move>() { new Moves.Drillpeck() },
			[32] = new List<Move>() { new Moves.Swagger() },
			[36] = new List<Move>() { new Moves.Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defog(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Sandattack(), new Moves.Skyattack(), new Moves.Spite(), new Moves.Tailwind() };
		public override int Weight => 18;
		public override int ExpYield => 49;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}