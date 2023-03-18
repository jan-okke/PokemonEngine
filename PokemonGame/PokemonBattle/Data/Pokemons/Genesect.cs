using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Genesect : Pokemon
	{
		public override string Name => "Genesect";
		public override List<Ability> AvailableAbilities => new() {new Download() };
		public override Stats BaseStats => new Stats(71, 120, 95, 99, 120, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Quickattack() },
			[7] = new List<Move>() { new Screech() },
			[14] = new List<Move>() { new Metalclaw() },
			[21] = new List<Move>() { new Fellstinger() },
			[28] = new List<Move>() { new Flamecharge() },
			[35] = new List<Move>() { new Metalsound() },
			[42] = new List<Move>() { new Xscissor() },
			[49] = new List<Move>() { new Magnetrise() },
			[56] = new List<Move>() { new Bugbuzz() },
			[63] = new List<Move>() { new Simplebeam() },
			[70] = new List<Move>() { new Zapcannon() },
			[77] = new List<Move>() { new Lockon() },
			[84] = new List<Move>() { new Technoblast() },
			[91] = new List<Move>() { new Selfdestruct() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Assurance(), new Blazekick(), new Blizzard(), new Bugbuzz(), new Darkpulse(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flamethrower(), new Flashcannon(), new Fly(), new Gigadrain(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Irondefense(), new Ironhead(), new Leechlife(), new Lightscreen(), new Protect(), new Psychic(), new Reflect(), new Rest(), new Round(), new Screech(), new Selfdestruct(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelbeam(), new Substitute(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Uturn(), new Xscissor(), new Zenheadbutt() };
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
}