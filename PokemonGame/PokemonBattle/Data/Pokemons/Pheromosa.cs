using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pheromosa : Pokemon
{
	public override string Name => "Pheromosa";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(71, 137, 37, 137, 37, 151);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Feint(), new Moves.Rapidspin() },
		[5] = new List<Move>() { new Moves.Leer() },
		[10] = new List<Move>() { new Moves.Quickguard() },
		[15] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Lowkick() },
		[25] = new List<Move>() { new Moves.Doublekick() },
		[30] = new List<Move>() { new Moves.Triplekick() },
		[35] = new List<Move>() { new Moves.Stomp() },
		[40] = new List<Move>() { new Moves.Agility() },
		[45] = new List<Move>() { new Moves.Lunge() },
		[50] = new List<Move>() { new Moves.Bounce() },
		[55] = new List<Move>() { new Moves.Speedswap() },
		[60] = new List<Move>() { new Moves.Bugbuzz() },
		[65] = new List<Move>() { new Moves.Quiverdance() },
		[70] = new List<Move>() { new Moves.Highjumpkick() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bugbuzz(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Drillrun(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Outrage(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Tripleaxel(), new Moves.Uturn() };
	public override int Weight => 250;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}