using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pheromosa : Pokemon
	{
		public override string Name => "Pheromosa";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(71, 137, 37, 151, 137, 37);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Feint(), new Rapidspin() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Quickguard() },
			[15] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Lowkick() },
			[25] = new List<Move>() { new Doublekick() },
			[30] = new List<Move>() { new Triplekick() },
			[35] = new List<Move>() { new Stomp() },
			[40] = new List<Move>() { new Agility() },
			[45] = new List<Move>() { new Lunge() },
			[50] = new List<Move>() { new Bounce() },
			[55] = new List<Move>() { new Speedswap() },
			[60] = new List<Move>() { new Bugbuzz() },
			[65] = new List<Move>() { new Quiverdance() },
			[70] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Blizzard(), new Bounce(), new Brickbreak(), new Bugbuzz(), new Closecombat(), new Coaching(), new Drillrun(), new Electroweb(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Lowkick(), new Lowsweep(), new Outrage(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Skittersmack(), new Sleeptalk(), new Snore(), new Speedswap(), new Substitute(), new Swift(), new Taunt(), new Throatchop(), new Tripleaxel(), new Uturn() };
		public override int Weight => 250;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}