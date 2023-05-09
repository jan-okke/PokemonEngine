using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Genesect : Pokemon
{
	public override string Name => "Genesect";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Download() };
	public override Stats BaseStats => new Stats(71, 120, 95, 120, 95, 99);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Quickattack() },
		[7] = new List<Move>() { new Moves.Screech() },
		[14] = new List<Move>() { new Moves.Metalclaw() },
		[21] = new List<Move>() { new Moves.Fellstinger() },
		[28] = new List<Move>() { new Moves.Flamecharge() },
		[35] = new List<Move>() { new Moves.Metalsound() },
		[42] = new List<Move>() { new Moves.Xscissor() },
		[49] = new List<Move>() { new Moves.Magnetrise() },
		[56] = new List<Move>() { new Moves.Bugbuzz() },
		[63] = new List<Move>() { new Moves.Simplebeam() },
		[70] = new List<Move>() { new Moves.Zapcannon() },
		[77] = new List<Move>() { new Moves.Lockon() },
		[84] = new List<Move>() { new Moves.Technoblast() },
		[91] = new List<Move>() { new Moves.Selfdestruct() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Blazekick(), new Moves.Blizzard(), new Moves.Bugbuzz(), new Moves.Darkpulse(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychic(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Uturn(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 825;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}