using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rotom : Pokemon
	{
		public override string Name => "Rotom";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(50, 50, 77, 95, 77, 91);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Doubleteam() },
			[5] = new List<Move>() { new Thundershock() },
			[10] = new List<Move>() { new Confuseray() },
			[15] = new List<Move>() { new Charge() },
			[20] = new List<Move>() { new Electroball() },
			[25] = new List<Move>() { new Thunderwave() },
			[30] = new List<Move>() { new Shockwave() },
			[35] = new List<Move>() { new Hex() },
			[40] = new List<Move>() { new Substitute() },
			[45] = new List<Move>() { new Trick() },
			[50] = new List<Move>() { new Discharge() },
			[55] = new List<Move>() { new Uproar() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Chargebeam(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hypervoice(), new Lightscreen(), new Nastyplot(), new Poltergeist(), new Protect(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Uproar(), new Voltswitch(), new Willowisp() };
		public override int Weight => 3;
		public override int ExpYield => 154;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}