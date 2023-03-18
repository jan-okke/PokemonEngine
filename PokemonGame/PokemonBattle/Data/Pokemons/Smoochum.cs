using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Smoochum : Pokemon
	{
		public override string Name => "Smoochum";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
		public override Stats BaseStats => new Stats(45, 30, 15, 85, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Lick(), new Moves.Pound() },
			[4] = new List<Move>() { new Moves.Powdersnow() },
			[8] = new List<Move>() { new Moves.Copycat() },
			[12] = new List<Move>() { new Moves.Confusion() },
			[16] = new List<Move>() { new Moves.Covet() },
			[20] = new List<Move>() { new Moves.Sing() },
			[24] = new List<Move>() { new Moves.Faketears() },
			[28] = new List<Move>() { new Moves.Icepunch() },
			[32] = new List<Move>() { new Moves.Psychic() },
			[36] = new List<Move>() { new Moves.Sweetkiss() },
			[40] = new List<Move>() { new Moves.Meanlook() },
			[44] = new List<Move>() { new Moves.Perishsong() },
			[48] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Fakeout(), new Moves.Icepunch(), new Moves.Roleplay(), new Moves.Wish() };
		public override int Weight => 60;
		public override int ExpYield => 61;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}