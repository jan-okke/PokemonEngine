using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Thundurus : Pokemon
	{
		public override string Name => "Thundurus";
		public override List<Ability> AvailableAbilities => new() {new Prankster() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(79, 115, 70, 125, 80, 111);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Thundershock() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Swagger() },
			[15] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Shockwave() },
			[25] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Charge() },
			[35] = new List<Move>() { new Voltswitch() },
			[40] = new List<Move>() { new Crunch() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Uproar() },
			[55] = new List<Move>() { new Hammerarm() },
			[60] = new List<Move>() { new Raindance() },
			[65] = new List<Move>() { new Thunder() },
			[70] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Crunch(), new Darkpulse(), new Eerieimpulse(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Fly(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Revenge(), new Risingvoltage(), new Round(), new Scaryface(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Smartstrike(), new Snore(), new Substitute(), new Superpower(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Uturn(), new Voltswitch(), new Weatherball(), new Wildcharge() };
		public override int Weight => 610;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}