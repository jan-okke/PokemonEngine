using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Castform : Pokemon
	{
		public override string Name => "Castform";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Forecast() };
		public override Stats BaseStats => new Stats(70, 70, 70, 70, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle() },
			[10] = new List<Move>() { new Moves.Watergun(), new Moves.Ember(), new Moves.Powdersnow() },
			[15] = new List<Move>() { new Moves.Headbutt() },
			[20] = new List<Move>() { new Moves.Raindance(), new Moves.Sunnyday(), new Moves.Hail() },
			[25] = new List<Move>() { new Moves.Weatherball() },
			[35] = new List<Move>() { new Moves.Hydropump(), new Moves.Fireblast(), new Moves.Blizzard() },
			[45] = new List<Move>() { new Moves.Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Frustration(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lastresort(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Waterpulse(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Clearsmog(), new Moves.Cosmicpower(), new Moves.Disable(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Hex(), new Moves.Reflecttype() };
		public override int Weight => 8;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
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