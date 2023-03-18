using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meowstic : Pokemon
	{
		public override string Name => "Meowstic";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
		public override Stats BaseStats => new Stats(74, 48, 76, 83, 81, 104);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Meanlook(), new Moves.Scratch(), new Moves.Leer(), new Moves.Fakeout(), new Moves.Disarmingvoice() },
			[9] = new List<Move>() { new Moves.Confusion() },
			[12] = new List<Move>() { new Moves.Helpinghand() },
			[15] = new List<Move>() { new Moves.Charm() },
			[18] = new List<Move>() { new Moves.Covet() },
			[21] = new List<Move>() { new Moves.Psybeam() },
			[24] = new List<Move>() { new Moves.Suckerpunch() },
			[29] = new List<Move>() { new Moves.Roleplay() },
			[34] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
			[39] = new List<Move>() { new Moves.Psyshock() },
			[44] = new List<Move>() { new Moves.Imprison() },
			[49] = new List<Move>() { new Moves.Quickguard() },
			[54] = new List<Move>() { new Moves.Psychic() },
			[59] = new List<Move>() { new Moves.Mistyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Mistyterrain(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 85;
		public override int ExpYield => 163;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}