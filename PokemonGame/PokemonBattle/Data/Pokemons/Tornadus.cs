using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tornadus : Pokemon
	{
		public override string Name => "Tornadus";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
		public override Stats BaseStats => new Stats(79, 115, 70, 125, 80, 111);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Astonish(), new Moves.Gust() },
			[5] = new List<Move>() { new Moves.Leer() },
			[10] = new List<Move>() { new Moves.Swagger() },
			[15] = new List<Move>() { new Moves.Bite() },
			[20] = new List<Move>() { new Moves.Aircutter() },
			[25] = new List<Move>() { new Moves.Agility() },
			[30] = new List<Move>() { new Moves.Tailwind() },
			[35] = new List<Move>() { new Moves.Airslash() },
			[40] = new List<Move>() { new Moves.Crunch() },
			[45] = new List<Move>() { new Moves.Extrasensory() },
			[50] = new List<Move>() { new Moves.Uproar() },
			[55] = new List<Move>() { new Moves.Hammerarm() },
			[60] = new List<Move>() { new Moves.Raindance() },
			[65] = new List<Move>() { new Moves.Hurricane() },
			[70] = new List<Move>() { new Moves.Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Weatherball() };
		public override int Weight => 630;
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