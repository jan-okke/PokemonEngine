using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dottler : Pokemon
	{
		public override string Name => "Dottler";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(50, 35, 80, 50, 90, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Reflect(), new Lightscreen(), new Confusion() },
			[1] = new List<Move>() { new Reflect(), new Lightscreen(), new Confusion(), new Strugglebug() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodypress(), new Bugbuzz(), new Calmmind(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Futuresight(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Irondefense(), new Leechlife(), new Lightscreen(), new Magicroom(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 195;
		public override int ExpYield => 117;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}