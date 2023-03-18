using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Trubbish : Pokemon
	{
		public override string Name => "Trubbish";
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aftermath() };
		public override Stats BaseStats => new Stats(50, 50, 62, 65, 40, 62);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Poisongas() },
			[3] = new List<Move>() { new Recycle() },
			[6] = new List<Move>() { new Acidspray() },
			[9] = new List<Move>() { new Amnesia() },
			[12] = new List<Move>() { new Clearsmog() },
			[15] = new List<Move>() { new Toxicspikes() },
			[18] = new List<Move>() { new Sludge() },
			[21] = new List<Move>() { new Stockpile(), new Swallow() },
			[24] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Sludgebomb() },
			[30] = new List<Move>() { new Toxic() },
			[33] = new List<Move>() { new Belch() },
			[37] = new List<Move>() { new Painsplit() },
			[39] = new List<Move>() { new Gunkshot() },
			[42] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Corrosivegas(), new Darkpulse(), new Drainpunch(), new Endure(), new Facade(), new Gigadrain(), new Gunkshot(), new Hiddenpower(), new Payback(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Round(), new Seedbomb(), new Selfdestruct(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Spikes(), new Substitute(), new Sunnyday(), new Thief(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Autotomize(), new Curse(), new Haze(), new Rollout(), new Sandattack() };
		public override int Weight => 310;
		public override int ExpYield => 66;
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