using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gorebyss : Pokemon
	{
		public override string Name => "Gorebyss";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(55, 84, 105, 114, 75, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Whirlpool(), new Confusion() },
			[5] = new List<Move>() { new Raindance() },
			[9] = new List<Move>() { new Agility() },
			[11] = new List<Move>() { new Drainingkiss() },
			[14] = new List<Move>() { new Waterpulse() },
			[16] = new List<Move>() { new Amnesia() },
			[19] = new List<Move>() { new Aquaring() },
			[23] = new List<Move>() { new Safeguard() },
			[26] = new List<Move>() { new Dive() },
			[29] = new List<Move>() { new Batonpass() },
			[34] = new List<Move>() { new Psychic() },
			[39] = new List<Move>() { new Aquatail() },
			[45] = new List<Move>() { new Coil() },
			[50] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Bind(), new Blizzard(), new Bounce(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Frustration(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Infestation(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse() };
		public override int Weight => 226;
		public override int ExpYield => 170;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}