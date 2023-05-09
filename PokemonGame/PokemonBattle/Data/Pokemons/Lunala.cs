using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lunala : Pokemon
{
	public override string Name => "Lunala";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shadowshield() };
	public override Stats BaseStats => new Stats(137, 113, 89, 137, 107, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Moongeistbeam() },
		[1] = new List<Move>() { new Moves.Moongeistbeam(), new Moves.Cosmicpower(), new Moves.Teleport(), new Moves.Confusion(), new Moves.Hypnosis() },
		[7] = new List<Move>() { new Moves.Nightshade() },
		[14] = new List<Move>() { new Moves.Confuseray() },
		[21] = new List<Move>() { new Moves.Airslash() },
		[28] = new List<Move>() { new Moves.Shadowball() },
		[35] = new List<Move>() { new Moves.Moonlight() },
		[42] = new List<Move>() { new Moves.Nightdaze() },
		[49] = new List<Move>() { new Moves.Magiccoat() },
		[56] = new List<Move>() { new Moves.Moonblast() },
		[63] = new List<Move>() { new Moves.Phantomforce() },
		[70] = new List<Move>() { new Moves.Dreameater() },
		[77] = new List<Move>() { new Moves.Wideguard() },
		[84] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Blizzard(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Meteorbeam(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Workup() };
	public override int Weight => 1200;
	public override int ExpYield => 340;
	public override int CatchRate => 45;
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