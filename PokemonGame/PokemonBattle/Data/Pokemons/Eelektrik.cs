using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eelektrik : Pokemon
	{
		public override string Name => "Eelektrik";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(65, 85, 70, 40, 75, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Crunch() },
			[1] = new List<Move>() { new Crunch(), new Headbutt(), new Thunderwave(), new Spark(), new Chargebeam() },
			[9] = new List<Move>() { new Bind() },
			[19] = new List<Move>() { new Acid() },
			[29] = new List<Move>() { new Discharge() },
			[44] = new List<Move>() { new Thunderbolt() },
			[49] = new List<Move>() { new Acidspray() },
			[54] = new List<Move>() { new Coil() },
			[59] = new List<Move>() { new Wildcharge() },
			[64] = new List<Move>() { new Gastroacid() },
			[69] = new List<Move>() { new Zapcannon() },
			[74] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aquatail(), new Attract(), new Bind(), new Bounce(), new Chargebeam(), new Confide(), new Doubleteam(), new Facade(), new Flashcannon(), new Frustration(), new Gastroacid(), new Gigadrain(), new Hiddenpower(), new Irontail(), new Knockoff(), new Lightscreen(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Superfang(), new Swagger(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Toxic(), new Uturn(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 220;
		public override int ExpYield => 142;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}