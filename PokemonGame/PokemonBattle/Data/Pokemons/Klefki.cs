using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klefki : Pokemon
	{
		public override string Name => "Klefki";
		public override List<Ability> AvailableAbilities => new() {new Prankster() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(57, 80, 91, 80, 87, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fairylock(), new Astonish() },
			[4] = new List<Move>() { new Tackle() },
			[8] = new List<Move>() { new Fairywind() },
			[12] = new List<Move>() { new Torment() },
			[16] = new List<Move>() { new Craftyshield() },
			[20] = new List<Move>() { new Metalsound() },
			[24] = new List<Move>() { new Drainingkiss() },
			[28] = new List<Move>() { new Recycle() },
			[32] = new List<Move>() { new Imprison() },
			[36] = new List<Move>() { new Flashcannon() },
			[40] = new List<Move>() { new Playrough() },
			[44] = new List<Move>() { new Magicroom() },
			[48] = new List<Move>() { new Foulplay() },
			[52] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Calmmind(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Facade(), new Flashcannon(), new Foulplay(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irondefense(), new Lightscreen(), new Magicroom(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Spikes(), new Steelbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Thief(), new Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Magnetrise(), new Switcheroo() };
		public override int Weight => 30;
		public override int ExpYield => 165;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}