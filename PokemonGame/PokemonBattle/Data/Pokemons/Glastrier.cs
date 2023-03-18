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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chillingneigh() };
		public override Stats BaseStats => new Stats(100, 145, 130, 65, 110, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
			[6] = new List<Move>() { new Moves.Doublekick() },
			[12] = new List<Move>() { new Moves.Avalanche() },
			[18] = new List<Move>() { new Moves.Stomp() },
			[24] = new List<Move>() { new Moves.Torment() },
			[30] = new List<Move>() { new Moves.Mist() },
			[36] = new List<Move>() { new Moves.Iciclecrash() },
			[42] = new List<Move>() { new Moves.Takedown() },
			[48] = new List<Move>() { new Moves.Irondefense() },
			[54] = new List<Move>() { new Moves.Thrash() },
			[60] = new List<Move>() { new Moves.Taunt() },
			[66] = new List<Move>() { new Moves.Doubleedge() },
			[72] = new List<Move>() { new Moves.Swordsdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lashout(), new Moves.Megahorn(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Uproar() };
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