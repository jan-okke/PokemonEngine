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
		public override List<Ability> AvailableAbilities => new() {new Forecast() };
		public override Stats BaseStats => new Stats(70, 70, 70, 70, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[10] = new List<Move>() { new Watergun(), new Ember(), new Powdersnow() },
			[15] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Raindance(), new Sunnyday(), new Hail() },
			[25] = new List<Move>() { new Weatherball() },
			[35] = new List<Move>() { new Hydropump(), new Fireblast(), new Blizzard() },
			[45] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Confide(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Lastresort(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Sandstorm(), new Scald(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Clearsmog(), new Cosmicpower(), new Disable(), new Futuresight(), new Guardswap(), new Hex(), new Reflecttype() };
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