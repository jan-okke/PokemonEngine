using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swadloon : Pokemon
	{
		public override string Name => "Swadloon";
		public override List<Ability> AvailableAbilities => new() {new Leafguard(), new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(55, 63, 90, 50, 80, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Protect() },
			[1] = new List<Move>() { new Protect(), new Grasswhistle(), new Tackle(), new Stringshot(), new Bugbite(), new Razorleaf() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbite(), new Calmmind(), new Confide(), new Cut(), new Doubleteam(), new Dreameater(), new Electroweb(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Payback(), new Protect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Worryseed() };
		public override int Weight => 73;
		public override int ExpYield => 133;
		public override int CatchRate => 120;
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