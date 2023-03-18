using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Elgyem : Pokemon
	{
		public override string Name => "Elgyem";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Telepathy(), new Abilities.Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
		public override Stats BaseStats => new Stats(55, 55, 55, 85, 55, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Confusion(), new Moves.Growl() },
			[6] = new List<Move>() { new Moves.Imprison() },
			[12] = new List<Move>() { new Moves.Teleport() },
			[18] = new List<Move>() { new Moves.Psybeam() },
			[24] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
			[30] = new List<Move>() { new Moves.Headbutt() },
			[36] = new List<Move>() { new Moves.Zenheadbutt() },
			[43] = new List<Move>() { new Moves.Recover() },
			[48] = new List<Move>() { new Moves.Calmmind() },
			[54] = new List<Move>() { new Moves.Wonderroom() },
			[60] = new List<Move>() { new Moves.Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Cosmicpower(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Nastyplot(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Destinybond(), new Moves.Disable(), new Moves.Psychup() };
		public override int Weight => 90;
		public override int ExpYield => 67;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}