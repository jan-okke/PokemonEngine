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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icescales() };
		public override Stats BaseStats => new Stats(70, 65, 60, 125, 90, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Icywind() },
			[1] = new List<Move>() { new Moves.Icywind(), new Moves.Powdersnow(), new Moves.Strugglebug(), new Moves.Helpinghand(), new Moves.Attract() },
			[4] = new List<Move>() { new Moves.Stunspore() },
			[8] = new List<Move>() { new Moves.Infestation() },
			[12] = new List<Move>() { new Moves.Mist() },
			[16] = new List<Move>() { new Moves.Defog() },
			[21] = new List<Move>() { new Moves.Featherdance() },
			[24] = new List<Move>() { new Moves.Aurorabeam() },
			[28] = new List<Move>() { new Moves.Hail() },
			[32] = new List<Move>() { new Moves.Bugbuzz() },
			[36] = new List<Move>() { new Moves.Auroraveil() },
			[40] = new List<Move>() { new Moves.Blizzard() },
			[44] = new List<Move>() { new Moves.Tailwind() },
			[48] = new List<Move>() { new Moves.Wideguard() },
			[52] = new List<Move>() { new Moves.Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Playrough(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Tripleaxel(), new Moves.Uturn(), new Moves.Weatherball() };
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