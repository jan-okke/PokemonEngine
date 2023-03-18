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
		public override List<Ability> AvailableAbilities => new() {new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(35, 64, 85, 74, 55, 32);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Whirlpool(), new Irondefense() },
			[50] = new List<Move>() { new Shellsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irondefense(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Bodyslam(), new Confuseray(), new Muddywater(), new Supersonic() };
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