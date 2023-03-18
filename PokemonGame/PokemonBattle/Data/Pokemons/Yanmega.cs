using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yanmega : Pokemon
	{
		public override string Name => "Yanmega";
		public override List<Ability> AvailableAbilities => new() {new Speedboost(), new Tintedlens() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(86, 76, 86, 116, 56, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bugbuzz(), new Airslash(), new Nightslash(), new Bugbite(), new Tackle(), new Gust(), new Quickattack(), new Doubleteam() },
			[6] = new List<Move>() { new Quickattack() },
			[11] = new List<Move>() { new Doubleteam() },
			[14] = new List<Move>() { new Aerialace() },
			[17] = new List<Move>() { new Detect() },
			[22] = new List<Move>() { new Supersonic() },
			[27] = new List<Move>() { new Uproar() },
			[30] = new List<Move>() { new Stringshot() },
			[33] = new List<Move>() { new Ancientpower() },
			[38] = new List<Move>() { new Feint() },
			[43] = new List<Move>() { new Slash() },
			[46] = new List<Move>() { new Screech() },
			[49] = new List<Move>() { new Uturn() },
			[54] = new List<Move>() { new Airslash() },
			[57] = new List<Move>() { new Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Leechlife(), new Protect(), new Psychic(), new Psychup(), new Rest(), new Return(), new Roost(), new Round(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Thief(), new Uproar(), new Uturn() };
		public override int Weight => 515;
		public override int ExpYield => 180;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}