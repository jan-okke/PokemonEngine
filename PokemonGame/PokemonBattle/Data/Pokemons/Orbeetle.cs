using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Orbeetle : Pokemon
{
	public override string Name => "Orbeetle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(60, 45, 110, 80, 120, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Reflect(), new Moves.Lightscreen(), new Moves.Confusion(), new Moves.Strugglebug() },
		[4] = new List<Move>() { new Moves.Confuseray() },
		[8] = new List<Move>() { new Moves.Magiccoat() },
		[12] = new List<Move>() { new Moves.Agility() },
		[16] = new List<Move>() { new Moves.Psybeam() },
		[20] = new List<Move>() { new Moves.Hypnosis() },
		[24] = new List<Move>() { new Moves.Allyswitch() },
		[28] = new List<Move>() { new Moves.Bugbuzz() },
		[32] = new List<Move>() { new Moves.Mirrorcoat() },
		[36] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Afteryou() },
		[44] = new List<Move>() { new Moves.Calmmind() },
		[48] = new List<Move>() { new Moves.Psychicterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodypress(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uturn(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 408;
	public override int ExpYield => 253;
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