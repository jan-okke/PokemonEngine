using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Reuniclus : Pokemon
{
	public override string Name => "Reuniclus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overcoat(), new Abilities.Magicguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(110, 65, 75, 125, 85, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Hammerarm() },
		[1] = new List<Move>() { new Moves.Hammerarm(), new Moves.Protect(), new Moves.Confusion(), new Moves.Recover(), new Moves.Endeavor() },
		[12] = new List<Move>() { new Moves.Psybeam() },
		[16] = new List<Move>() { new Moves.Charm() },
		[20] = new List<Move>() { new Moves.Psyshock() },
		[24] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
		[28] = new List<Move>() { new Moves.Allyswitch() },
		[35] = new List<Move>() { new Moves.Painsplit() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[48] = new List<Move>() { new Moves.Skillswap() },
		[56] = new List<Move>() { new Moves.Futuresight() },
		[64] = new List<Move>() { new Moves.Wonderroom() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Megapunch(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Thunder(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 201;
	public override int ExpYield => 245;
	public override int CatchRate => 50;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}