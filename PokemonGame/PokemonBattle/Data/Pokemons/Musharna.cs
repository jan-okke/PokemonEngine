using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Musharna : Pokemon
{
	public override string Name => "Musharna";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Forewarn(), new Abilities.Synchronize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(116, 55, 85, 107, 95, 29);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Psychicterrain(), new Moves.Imprison(), new Moves.Moonlight(), new Moves.Magiccoat(), new Moves.Zenheadbutt(), new Moves.Calmmind(), new Moves.Yawn(), new Moves.Psychic(), new Moves.Moonblast(), new Moves.Dreameater(), new Moves.Futuresight(), new Moves.Wonderroom(), new Moves.Storedpower(), new Moves.Defensecurl(), new Moves.Hypnosis(), new Moves.Psybeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Mistyexplosion(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 605;
	public override int ExpYield => 170;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}