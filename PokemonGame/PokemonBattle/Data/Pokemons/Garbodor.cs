using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Garbodor : Pokemon
	{
		public override string Name => "Garbodor";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Stench(), new Abilities.Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aftermath() };
		public override Stats BaseStats => new Stats(80, 95, 82, 60, 82, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Takedown(), new Moves.Metalclaw(), new Moves.Poisongas(), new Moves.Recycle(), new Moves.Acidspray() },
			[9] = new List<Move>() { new Moves.Amnesia() },
			[12] = new List<Move>() { new Moves.Clearsmog() },
			[15] = new List<Move>() { new Moves.Toxicspikes() },
			[18] = new List<Move>() { new Moves.Sludge() },
			[21] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow() },
			[24] = new List<Move>() { new Moves.Bodyslam() },
			[27] = new List<Move>() { new Moves.Sludgebomb() },
			[30] = new List<Move>() { new Moves.Toxic() },
			[33] = new List<Move>() { new Moves.Belch() },
			[39] = new List<Move>() { new Moves.Painsplit() },
			[43] = new List<Move>() { new Moves.Gunkshot() },
			[48] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Corrosivegas(), new Moves.Crosspoison(), new Moves.Darkpulse(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
		public override int Weight => 1073;
		public override int ExpYield => 166;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}