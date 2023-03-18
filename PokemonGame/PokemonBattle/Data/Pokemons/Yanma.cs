using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yanma : Pokemon
	{
		public override string Name => "Yanma";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Speedboost(), new Abilities.Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(65, 65, 45, 75, 45, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Gust() },
			[6] = new List<Move>() { new Moves.Quickattack() },
			[11] = new List<Move>() { new Moves.Doubleteam() },
			[14] = new List<Move>() { new Moves.Aerialace() },
			[17] = new List<Move>() { new Moves.Detect() },
			[22] = new List<Move>() { new Moves.Supersonic() },
			[27] = new List<Move>() { new Moves.Uproar() },
			[30] = new List<Move>() { new Moves.Stringshot() },
			[33] = new List<Move>() { new Moves.Ancientpower() },
			[38] = new List<Move>() { new Moves.Hypnosis() },
			[43] = new List<Move>() { new Moves.Wingattack() },
			[46] = new List<Move>() { new Moves.Screech() },
			[49] = new List<Move>() { new Moves.Uturn() },
			[54] = new List<Move>() { new Moves.Airslash() },
			[57] = new List<Move>() { new Moves.Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Feint(), new Moves.Leechlife(), new Moves.Reversal(), new Moves.Whirlwind() };
		public override int Weight => 380;
		public override int ExpYield => 78;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}