using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spritzee : Pokemon
	{
		public override string Name => "Spritzee";
		public override List<Ability> AvailableAbilities => new() {new Healer() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aromaveil() };
		public override Stats BaseStats => new Stats(78, 52, 60, 63, 65, 23);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fairywind(), new Sweetscent() },
			[3] = new List<Move>() { new Sweetkiss() },
			[6] = new List<Move>() { new Echoedvoice() },
			[9] = new List<Move>() { new Drainingkiss() },
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
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Flashcannon(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Lightscreen(), new Mistyexplosion(), new Mistyterrain(), new Nastyplot(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Round(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Thunderbolt(), new Trickroom() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Disable(), new Wish() };
		public override int Weight => 5;
		public override int ExpYield => 68;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}