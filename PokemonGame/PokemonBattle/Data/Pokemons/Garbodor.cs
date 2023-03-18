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
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aftermath() };
		public override Stats BaseStats => new Stats(80, 95, 82, 60, 82, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Takedown(), new Metalclaw(), new Poisongas(), new Recycle(), new Acidspray() },
			[9] = new List<Move>() { new Amnesia() },
			[12] = new List<Move>() { new Clearsmog() },
			[15] = new List<Move>() { new Toxicspikes() },
			[18] = new List<Move>() { new Sludge() },
			[21] = new List<Move>() { new Stockpile(), new Swallow() },
			[24] = new List<Move>() { new Bodyslam() },
			[27] = new List<Move>() { new Sludgebomb() },
			[30] = new List<Move>() { new Toxic() },
			[33] = new List<Move>() { new Belch() },
			[39] = new List<Move>() { new Painsplit() },
			[43] = new List<Move>() { new Gunkshot() },
			[48] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodypress(), new Bodyslam(), new Corrosivegas(), new Crosspoison(), new Darkpulse(), new Drainpunch(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Gigadrain(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockblast(), new Round(), new Screech(), new Seedbomb(), new Selfdestruct(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Solarbeam(), new Spikes(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Thief(), new Thunderbolt(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
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