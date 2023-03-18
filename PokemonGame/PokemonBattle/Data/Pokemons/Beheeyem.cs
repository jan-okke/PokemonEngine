using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Beheeyem : Pokemon
	{
		public override string Name => "Beheeyem";
		public override List<Ability> AvailableAbilities => new() {new Telepathy(), new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(75, 75, 75, 40, 125, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Psychicterrain(), new Confusion(), new Growl(), new Imprison(), new Teleport() },
			[18] = new List<Move>() { new Psybeam() },
			[24] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[30] = new List<Move>() { new Headbutt() },
			[36] = new List<Move>() { new Zenheadbutt() },
			[45] = new List<Move>() { new Recover() },
			[52] = new List<Move>() { new Calmmind() },
			[60] = new List<Move>() { new Wonderroom() },
			[68] = new List<Move>() { new Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Calmmind(), new Cosmicpower(), new Darkpulse(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flashcannon(), new Futuresight(), new Gigaimpact(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Meteorbeam(), new Nastyplot(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Screech(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Steelwing(), new Storedpower(), new Substitute(), new Thief(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Uproar(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 345;
		public override int ExpYield => 170;
		public override int CatchRate => 90;
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
}