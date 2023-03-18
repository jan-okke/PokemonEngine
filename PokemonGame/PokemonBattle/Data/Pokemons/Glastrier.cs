using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Glastrier : Pokemon
	{
		public override string Name => "Glastrier";
		public override List<Ability> AvailableAbilities => new() {new Chillingneigh() };
		public override Stats BaseStats => new Stats(100, 145, 130, 65, 110, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[6] = new List<Move>() { new Doublekick() },
			[12] = new List<Move>() { new Avalanche() },
			[18] = new List<Move>() { new Stomp() },
			[24] = new List<Move>() { new Torment() },
			[30] = new List<Move>() { new Mist() },
			[36] = new List<Move>() { new Iciclecrash() },
			[42] = new List<Move>() { new Takedown() },
			[48] = new List<Move>() { new Irondefense() },
			[54] = new List<Move>() { new Thrash() },
			[60] = new List<Move>() { new Taunt() },
			[66] = new List<Move>() { new Doubleedge() },
			[72] = new List<Move>() { new Swordsdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Crunch(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Lashout(), new Megahorn(), new Mudshot(), new Outrage(), new Payback(), new Protect(), new Rest(), new Round(), new Scaryface(), new Sleeptalk(), new Smartstrike(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Swordsdance(), new Taunt(), new Throatchop(), new Uproar() };
		public override int Weight => 8000;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}