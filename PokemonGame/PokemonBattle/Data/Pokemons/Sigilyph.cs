using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sigilyph : Pokemon
{
	public override string Name => "Sigilyph";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Wonderskin(), new Abilities.Magicguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tintedlens() };
	public override Stats BaseStats => new Stats(72, 58, 80, 103, 80, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Confusion() },
		[5] = new List<Move>() { new Moves.Gravity() },
		[10] = new List<Move>() { new Moves.Hypnosis() },
		[15] = new List<Move>() { new Moves.Aircutter() },
		[20] = new List<Move>() { new Moves.Psybeam() },
		[25] = new List<Move>() { new Moves.Whirlwind() },
		[30] = new List<Move>() { new Moves.Cosmicpower() },
		[35] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[45] = new List<Move>() { new Moves.Tailwind() },
		[50] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
		[55] = new List<Move>() { new Moves.Skyattack() },
		[60] = new List<Move>() { new Moves.Skillswap() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Psychoshift(), new Moves.Roost() };
	public override int Weight => 140;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}