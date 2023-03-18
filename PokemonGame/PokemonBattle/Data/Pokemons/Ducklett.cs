using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ducklett : Pokemon
	{
		public override string Name => "Ducklett";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Bigpecks() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(62, 44, 50, 44, 50, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun() },
			[3] = new List<Move>() { new Watersport() },
			[6] = new List<Move>() { new Defog() },
			[9] = new List<Move>() { new Wingattack() },
			[13] = new List<Move>() { new Waterpulse() },
			[15] = new List<Move>() { new Aerialace() },
			[19] = new List<Move>() { new Bubblebeam() },
			[21] = new List<Move>() { new Featherdance() },
			[24] = new List<Move>() { new Aquaring() },
			[27] = new List<Move>() { new Airslash() },
			[30] = new List<Move>() { new Roost() },
			[34] = new List<Move>() { new Raindance() },
			[37] = new List<Move>() { new Tailwind() },
			[41] = new List<Move>() { new Bravebird() },
			[46] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Dive(), new Doubleteam(), new Endeavor(), new Facade(), new Fly(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Surf(), new Swagger(), new Tailwind(), new Toxic(), new Uproar(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Aircutter(), new Aquajet(), new Brine(), new Gust(), new Luckychant(), new Mefirst(), new Mirrormove(), new Mudsport(), new Steelwing() };
		public override int Weight => 55;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
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