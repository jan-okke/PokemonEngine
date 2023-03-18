using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Beautifly : Pokemon
	{
		public override string Name => "Beautifly";
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rivalry() };
		public override Stats BaseStats => new Stats(60, 70, 50, 65, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Gust() },
			[1] = new List<Move>() { new Gust() },
			[12] = new List<Move>() { new Absorb() },
			[15] = new List<Move>() { new Stunspore() },
			[17] = new List<Move>() { new Morningsun() },
			[20] = new List<Move>() { new Aircutter() },
			[22] = new List<Move>() { new Megadrain() },
			[25] = new List<Move>() { new Leechlife() },
			[27] = new List<Move>() { new Attract() },
			[30] = new List<Move>() { new Whirlwind() },
			[32] = new List<Move>() { new Gigadrain() },
			[35] = new List<Move>() { new Bugbuzz() },
			[37] = new List<Move>() { new Protect() },
			[40] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Laserfocus(), new Protect(), new Psychic(), new Rest(), new Return(), new Roost(), new Round(), new Safeguard(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Venoshock() };
		public override int Weight => 284;
		public override int ExpYield => 198;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}