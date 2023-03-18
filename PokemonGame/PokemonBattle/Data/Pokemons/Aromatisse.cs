using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aromatisse : Pokemon
	{
		public override string Name => "Aromatisse";
		public override List<Ability> AvailableAbilities => new() {new Healer() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aromaveil() };
		public override Stats BaseStats => new Stats(101, 72, 72, 99, 89, 29);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Aromaticmist(), new Healpulse(), new Fairywind(), new Sweetscent(), new Sweetkiss(), new Echoedvoice() },
			[9] = new List<Move>() { new Disarmingvoice() },
			[12] = new List<Move>() { new Aromatherapy() },
			[15] = new List<Move>() { new Drainingkiss() },
			[18] = new List<Move>() { new Attract() },
			[21] = new List<Move>() { new Flail() },
			[24] = new List<Move>() { new Mistyterrain() },
			[27] = new List<Move>() { new Psychic() },
			[30] = new List<Move>() { new Charm() },
			[33] = new List<Move>() { new Calmmind() },
			[36] = new List<Move>() { new Moonblast() },
			[39] = new List<Move>() { new Skillswap() },
			[42] = new List<Move>() { new Psychup() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Metronome(), new Mistyexplosion(), new Mistyterrain(), new Nastyplot(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Thunder(), new Thunderbolt(), new Trickroom() };
		public override int Weight => 155;
		public override int ExpYield => 162;
		public override int CatchRate => 140;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}