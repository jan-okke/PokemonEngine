using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ferrothorn : Pokemon
	{
		public override string Name => "Ferrothorn";
		public override List<Ability> AvailableAbilities => new() {new Ironbarbs() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Anticipation() };
		public override Stats BaseStats => new Stats(74, 94, 131, 20, 54, 116);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Powerwhip() },
			[1] = new List<Move>() { new Powerwhip(), new Tackle(), new Harden(), new Metalclaw(), new Pinmissile() },
			[15] = new List<Move>() { new Ingrain() },
			[20] = new List<Move>() { new Flashcannon() },
			[25] = new List<Move>() { new Ironhead() },
			[30] = new List<Move>() { new Selfdestruct() },
			[35] = new List<Move>() { new Irondefense() },
			[43] = new List<Move>() { new Curse() },
			[49] = new List<Move>() { new Gyroball() },
			[56] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodypress(), new Brutalswing(), new Bulldoze(), new Bulletseed(), new Endure(), new Energyball(), new Facade(), new Flashcannon(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Payback(), new Pinmissile(), new Poisonjab(), new Powerwhip(), new Protect(), new Rest(), new Revenge(), new Round(), new Sandstorm(), new Seedbomb(), new Selfdestruct(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spikes(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Substitute(), new Sunnyday(), new Swordsdance(), new Thunder(), new Thunderbolt(), new Thunderwave() };
		public override int Weight => 1100;
		public override int ExpYield => 171;
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