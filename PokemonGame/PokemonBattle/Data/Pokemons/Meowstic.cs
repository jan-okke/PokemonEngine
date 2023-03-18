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
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(74, 48, 76, 83, 81, 104);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Meanlook(), new Scratch(), new Leer(), new Fakeout(), new Disarmingvoice() },
			[9] = new List<Move>() { new Confusion() },
			[12] = new List<Move>() { new Helpinghand() },
			[15] = new List<Move>() { new Charm() },
			[18] = new List<Move>() { new Covet() },
			[21] = new List<Move>() { new Psybeam() },
			[24] = new List<Move>() { new Suckerpunch() },
			[29] = new List<Move>() { new Roleplay() },
			[34] = new List<Move>() { new Lightscreen(), new Reflect() },
			[39] = new List<Move>() { new Psyshock() },
			[44] = new List<Move>() { new Imprison() },
			[49] = new List<Move>() { new Quickguard() },
			[54] = new List<Move>() { new Psychic() },
			[59] = new List<Move>() { new Mistyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Darkpulse(), new Dig(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irontail(), new Lightscreen(), new Magicroom(), new Mistyterrain(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Tailslap(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Workup(), new Zenheadbutt() };
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