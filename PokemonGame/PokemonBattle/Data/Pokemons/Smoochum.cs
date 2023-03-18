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
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(45, 30, 15, 65, 85, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lick(), new Pound() },
			[4] = new List<Move>() { new Powdersnow() },
			[8] = new List<Move>() { new Copycat() },
			[12] = new List<Move>() { new Confusion() },
			[16] = new List<Move>() { new Covet() },
			[20] = new List<Move>() { new Sing() },
			[24] = new List<Move>() { new Faketears() },
			[28] = new List<Move>() { new Icepunch() },
			[32] = new List<Move>() { new Psychic() },
			[36] = new List<Move>() { new Sweetkiss() },
			[40] = new List<Move>() { new Meanlook() },
			[44] = new List<Move>() { new Perishsong() },
			[48] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Calmmind(), new Charm(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Encore(), new Endure(), new Facade(), new Faketears(), new Flash(), new Fling(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swagger(), new Thief(), new Trick(), new Trickroom(), new Uproar(), new Waterpulse(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Fakeout(), new Icepunch(), new Roleplay(), new Wish() };
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