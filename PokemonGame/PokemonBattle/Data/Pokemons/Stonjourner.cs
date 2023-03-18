using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stonjourner : Pokemon
	{
		public override string Name => "Stonjourner";
		public override List<Ability> AvailableAbilities => new() {new Powerspot() };
		public override Stats BaseStats => new Stats(100, 125, 135, 70, 20, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rockthrow(), new Block() },
			[6] = new List<Move>() { new Rockpolish() },
			[12] = new List<Move>() { new Rocktomb() },
			[18] = new List<Move>() { new Gravity() },
			[24] = new List<Move>() { new Stomp() },
			[30] = new List<Move>() { new Stealthrock() },
			[36] = new List<Move>() { new Rockslide() },
			[42] = new List<Move>() { new Bodyslam() },
			[48] = new List<Move>() { new Wideguard() },
			[54] = new List<Move>() { new Heavyslam() },
			[60] = new List<Move>() { new Stoneedge() },
			[66] = new List<Move>() { new Megakick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodypress(), new Bodyslam(), new Brutalswing(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irondefense(), new Megakick(), new Meteorbeam(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Curse() };
		public override int Weight => 5200;
		public override int ExpYield => 165;
		public override int CatchRate => 60;
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