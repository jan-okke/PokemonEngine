using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Nihilego : Pokemon
{
	public override string Name => "Nihilego";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(109, 53, 47, 127, 131, 103);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Pound() },
		[5] = new List<Move>() { new Moves.Acid() },
		[10] = new List<Move>() { new Moves.Tickle() },
		[15] = new List<Move>() { new Moves.Acidspray() },
		[20] = new List<Move>() { new Moves.Clearsmog() },
		[25] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
		[30] = new List<Move>() { new Moves.Venoshock() },
		[35] = new List<Move>() { new Moves.Headbutt() },
		[40] = new List<Move>() { new Moves.Toxicspikes() },
		[45] = new List<Move>() { new Moves.Venomdrench() },
		[50] = new List<Move>() { new Moves.Powergem() },
		[55] = new List<Move>() { new Moves.Stealthrock() },
		[60] = new List<Move>() { new Moves.Mirrorcoat() },
		[65] = new List<Move>() { new Moves.Wonderroom() },
		[70] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Corrosivegas(), new Moves.Crosspoison(), new Moves.Dazzlinggleam(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Poisonjab(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Toxicspikes(), new Moves.Trickroom(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 555;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}