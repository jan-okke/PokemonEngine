using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Espurr : Pokemon
	{
		public override string Name => "Espurr";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Owntempo() };
		public override Stats BaseStats => new Stats(62, 48, 54, 68, 63, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[3] = new List<Move>() { new Fakeout() },
			[6] = new List<Move>() { new Disarmingvoice() },
			[9] = new List<Move>() { new Confusion() },
			[18] = new List<Move>() { new Covet() },
			[21] = new List<Move>() { new Psybeam() },
			[30] = new List<Move>() { new Lightscreen(), new Reflect() },
			[33] = new List<Move>() { new Psyshock() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Darkpulse(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Magicroom(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Tickle(), new Yawn() };
		public override int Weight => 35;
		public override int ExpYield => 71;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}