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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Healer() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aromaveil() };
		public override Stats BaseStats => new Stats(78, 52, 60, 63, 65, 23);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Fairywind(), new Moves.Sweetscent() },
			[3] = new List<Move>() { new Moves.Sweetkiss() },
			[6] = new List<Move>() { new Moves.Echoedvoice() },
			[9] = new List<Move>() { new Moves.Drainingkiss() },
			[12] = new List<Move>() { new Moves.Aromatherapy() },
			[15] = new List<Move>() { new Moves.Drainingkiss() },
			[18] = new List<Move>() { new Moves.Attract() },
			[21] = new List<Move>() { new Moves.Flail() },
			[24] = new List<Move>() { new Moves.Mistyterrain() },
			[27] = new List<Move>() { new Moves.Psychic() },
			[30] = new List<Move>() { new Moves.Charm() },
			[33] = new List<Move>() { new Moves.Calmmind() },
			[36] = new List<Move>() { new Moves.Moonblast() },
			[39] = new List<Move>() { new Moves.Skillswap() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderbolt(), new Moves.Trickroom() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Disable(), new Moves.Wish() };
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