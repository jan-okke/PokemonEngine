using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dottler : Pokemon
{
	public override string Name => "Dottler";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Compoundeyes() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(50, 35, 80, 50, 90, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Reflect(), new Moves.Lightscreen(), new Moves.Confusion() },
		[1] = new List<Move>() { new Moves.Reflect(), new Moves.Lightscreen(), new Moves.Confusion(), new Moves.Strugglebug() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 195;
	public override int ExpYield => 117;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}