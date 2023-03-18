using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Alcremie : Pokemon
	{
		public override string Name => "Alcremie";
		public override List<Ability> AvailableAbilities => new() {new Sweetveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aromaveil() };
		public override Stats BaseStats => new Stats(65, 60, 75, 110, 121, 64);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Decorate() },
			[1] = new List<Move>() { new Decorate(), new Tackle(), new Aromaticmist(), new Sweetkiss(), new Sweetscent() },
			[15] = new List<Move>() { new Drainingkiss() },
			[20] = new List<Move>() { new Aromatherapy() },
			[25] = new List<Move>() { new Attract() },
			[30] = new List<Move>() { new Acidarmor() },
			[35] = new List<Move>() { new Dazzlinggleam() },
			[40] = new List<Move>() { new Recover() },
			[45] = new List<Move>() { new Mistyterrain() },
			[50] = new List<Move>() { new Entrainment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Fling(), new Gigadrain(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Metronome(), new Mistyexplosion(), new Mistyterrain(), new Mysticalfire(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Triattack(), new Wonderroom() };
		public override int Weight => 5;
		public override int ExpYield => 173;
		public override int CatchRate => 100;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}