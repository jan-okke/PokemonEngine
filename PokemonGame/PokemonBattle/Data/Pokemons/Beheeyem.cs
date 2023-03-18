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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Telepathy(), new Abilities.Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
		public override Stats BaseStats => new Stats(75, 75, 75, 125, 95, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Psychicterrain(), new Moves.Confusion(), new Moves.Growl(), new Moves.Imprison(), new Moves.Teleport() },
			[18] = new List<Move>() { new Moves.Psybeam() },
			[24] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
			[30] = new List<Move>() { new Moves.Headbutt() },
			[36] = new List<Move>() { new Moves.Zenheadbutt() },
			[45] = new List<Move>() { new Moves.Recover() },
			[52] = new List<Move>() { new Moves.Calmmind() },
			[60] = new List<Move>() { new Moves.Wonderroom() },
			[68] = new List<Move>() { new Moves.Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Nastyplot(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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