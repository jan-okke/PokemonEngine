using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dustox : Pokemon
	{
		public override string Name => "Dustox";
		public override List<Ability> AvailableAbilities => new() {new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Compoundeyes() };
		public override Stats BaseStats => new Stats(60, 50, 70, 50, 90, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Gust() },
			[1] = new List<Move>() { new Gust() },
			[12] = new List<Move>() { new Confusion() },
			[15] = new List<Move>() { new Poisonpowder() },
			[17] = new List<Move>() { new Moonlight() },
			[20] = new List<Move>() { new Venoshock() },
			[22] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Leechlife() },
			[27] = new List<Move>() { new Lightscreen() },
			[30] = new List<Move>() { new Whirlwind() },
			[32] = new List<Move>() { new Toxic() },
			[35] = new List<Move>() { new Bugbuzz() },
			[37] = new List<Move>() { new Protect() },
			[40] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Laserfocus(), new Lightscreen(), new Protect(), new Psychic(), new Rest(), new Return(), new Roost(), new Round(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Toxic(), new Uturn(), new Venoshock() };
		public override int Weight => 316;
		public override int ExpYield => 193;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}