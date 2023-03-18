using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Frosmoth : Pokemon
	{
		public override string Name => "Frosmoth";
		public override List<Ability> AvailableAbilities => new() {new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icescales() };
		public override Stats BaseStats => new Stats(70, 65, 60, 125, 90, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Icywind() },
			[1] = new List<Move>() { new Icywind(), new Powdersnow(), new Strugglebug(), new Helpinghand(), new Attract() },
			[4] = new List<Move>() { new Stunspore() },
			[8] = new List<Move>() { new Infestation() },
			[12] = new List<Move>() { new Mist() },
			[16] = new List<Move>() { new Defog() },
			[21] = new List<Move>() { new Featherdance() },
			[24] = new List<Move>() { new Aurorabeam() },
			[28] = new List<Move>() { new Hail() },
			[32] = new List<Move>() { new Bugbuzz() },
			[36] = new List<Move>() { new Auroraveil() },
			[40] = new List<Move>() { new Blizzard() },
			[44] = new List<Move>() { new Tailwind() },
			[48] = new List<Move>() { new Wideguard() },
			[52] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Attract(), new Avalanche(), new Blizzard(), new Bugbuzz(), new Calmmind(), new Dazzlinggleam(), new Dualwingbeat(), new Endure(), new Facade(), new Gigadrain(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Imprison(), new Leechlife(), new Lightscreen(), new Playrough(), new Protect(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Tripleaxel(), new Uturn(), new Weatherball() };
		public override int Weight => 420;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}