using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Blacephalon : Pokemon
{
	public override string Name => "Blacephalon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(53, 127, 53, 151, 79, 107);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Firespin() },
		[5] = new List<Move>() { new Moves.Lightscreen() },
		[10] = new List<Move>() { new Moves.Ember() },
		[15] = new List<Move>() { new Moves.Nightshade() },
		[20] = new List<Move>() { new Moves.Confuseray() },
		[25] = new List<Move>() { new Moves.Magiccoat() },
		[30] = new List<Move>() { new Moves.Incinerate() },
		[35] = new List<Move>() { new Moves.Hypnosis() },
		[40] = new List<Move>() { new Moves.Mysticalfire() },
		[45] = new List<Move>() { new Moves.Shadowball() },
		[50] = new List<Move>() { new Moves.Calmmind() },
		[55] = new List<Move>() { new Moves.Willowisp() },
		[60] = new List<Move>() { new Moves.Trick() },
		[65] = new List<Move>() { new Moves.Fireblast() },
		[70] = new List<Move>() { new Moves.Mindblown() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Encore(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Uproar(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
	public override int Weight => 130;
	public override int ExpYield => 285;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}