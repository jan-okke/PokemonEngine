using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Anorith : Pokemon
	{
		public override string Name => "Anorith";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
		public override Stats BaseStats => new Stats(45, 95, 50, 40, 50, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Harden() },
			[4] = new List<Move>() { new Moves.Watergun() },
			[8] = new List<Move>() { new Moves.Smackdown() },
			[12] = new List<Move>() { new Moves.Metalclaw() },
			[16] = new List<Move>() { new Moves.Ancientpower() },
			[20] = new List<Move>() { new Moves.Bugbite() },
			[24] = new List<Move>() { new Moves.Brine() },
			[28] = new List<Move>() { new Moves.Slash() },
			[32] = new List<Move>() { new Moves.Crushclaw() },
			[36] = new List<Move>() { new Moves.Rockblast() },
			[41] = new List<Move>() { new Moves.Protect() },
			[44] = new List<Move>() { new Moves.Xscissor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Waterpulse(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Crosspoison(), new Moves.Curse(), new Moves.Irondefense(), new Moves.Knockoff(), new Moves.Rapidspin(), new Moves.Sandattack(), new Moves.Screech() };
		public override int Weight => 125;
		public override int ExpYield => 71;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}