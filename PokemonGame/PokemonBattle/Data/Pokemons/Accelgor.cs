using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Accelgor : Pokemon
	{
		public override string Name => "Accelgor";
		public override List<Ability> AvailableAbilities => new() {new Hydration(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unburden() };
		public override Stats BaseStats => new Stats(80, 70, 40, 145, 100, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watershuriken(), new Acid(), new Curse(), new Yawn(), new Acidarmor(), new Guardswap(), new Bodyslam(), new Absorb(), new Doubleteam(), new Acidspray(), new Quickattack() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Strugglebug() },
			[20] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Powerswap() },
			[36] = new List<Move>() { new Uturn() },
			[40] = new List<Move>() { new Recover() },
			[44] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Finalgambit() },
			[52] = new List<Move>() { new Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Batonpass(), new Bodyslam(), new Bugbuzz(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Focusblast(), new Gigadrain(), new Gigaimpact(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Mudshot(), new Powerswap(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Round(), new Sandstorm(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Spikes(), new Substitute(), new Swift(), new Toxicspikes(), new Uturn(), new Venomdrench(), new Venoshock() };
		public override int Weight => 253;
		public override int ExpYield => 173;
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