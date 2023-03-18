using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Polteageist : Pokemon
	{
		public override string Name => "Polteageist";
		public override List<Ability> AvailableAbilities => new() {new Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(60, 65, 65, 134, 114, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Teatime() },
			[1] = new List<Move>() { new Teatime(), new Strengthsap(), new Astonish(), new Withdraw(), new Aromaticmist(), new Megadrain() },
			[18] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Suckerpunch() },
			[30] = new List<Move>() { new Aromatherapy() },
			[36] = new List<Move>() { new Gigadrain() },
			[42] = new List<Move>() { new Nastyplot() },
			[48] = new List<Move>() { new Shadowball() },
			[54] = new List<Move>() { new Memento() },
			[60] = new List<Move>() { new Shellsmash() },
			[66] = new List<Move>() { new Curse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Batonpass(), new Darkpulse(), new Endure(), new Facade(), new Foulplay(), new Gigadrain(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Metronome(), new Nastyplot(), new Payback(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Trick(), new Willowisp(), new Wonderroom() };
		public override int Weight => 4;
		public override int ExpYield => 178;
		public override int CatchRate => 60;
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