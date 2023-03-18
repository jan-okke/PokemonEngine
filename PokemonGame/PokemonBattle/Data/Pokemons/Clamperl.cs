using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clamperl : Pokemon
	{
		public override string Name => "Clamperl";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
		public override Stats BaseStats => new Stats(35, 64, 85, 74, 55, 32);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Whirlpool(), new Moves.Irondefense() },
			[50] = new List<Move>() { new Moves.Shellsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Bodyslam(), new Moves.Confuseray(), new Moves.Muddywater(), new Moves.Supersonic() };
		public override int Weight => 525;
		public override int ExpYield => 69;
		public override int CatchRate => 255;
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